--Stored Procedure tạo user 
CREATE OR REPLACE PROCEDURE SP_CREATEUSER(
    p_username IN VARCHAR2,
    p_password IN VARCHAR2
)    
AS
    v_count NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM dba_users
    WHERE USERNAME = upper(p_username);
    if v_count > 0 then
        RAISE_APPLICATION_ERROR(-20001, 'Username already exists');
    ELSE
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'CREATE USER '||p_username||' IDENTIFIED BY '||p_password;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT CONNECT TO '||p_username;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
        EXECUTE IMMEDIATE(STRSQL);
    END IF;
END;

--Stored Procedure drop user
CREATE OR REPLACE PROCEDURE SP_DROPUSER(
    p_username IN VARCHAR2
)    
AS
    v_count NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM dba_users
    WHERE USERNAME = upper(p_username);
    if v_count > 0 then
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'DROP USER ' || p_username;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
        EXECUTE IMMEDIATE(STRSQL);
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Username does not exist');
    END IF;
END;

--Stored procedure đổi mật khẩu người dùng
CREATE OR REPLACE PROCEDURE SP_CHANGEUSRPW(
    p_username IN VARCHAR2,
    p_password IN VARCHAR2
)    
AS
    v_count NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM dba_users
    WHERE USERNAME = upper(p_username);
    if v_count > 0 then
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'ALTER USER ' || p_username || ' IDENTIFIED BY ' || p_password;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
        EXECUTE IMMEDIATE(STRSQL);
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Username does not exist');
    END IF;
END;

--Stored procedure Grant quyền truy cập đến role/user
CREATE OR REPLACE PROCEDURE SP_GRANTPRIVUSER(
    p_user IN VARCHAR2,
    priv IN VARCHAR2,
    obj IN VARCHAR2,
    g_option IN NUMBER
    
)    
AS
    v_count NUMBER;
    v_count2 NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM dba_users
    WHERE USERNAME = upper(p_user);
    SELECT COUNT(*)
    INTO v_count2
    FROM dba_roles
    WHERE ROLE = upper(p_user);
    if (v_count + v_count2) > 0 then
        if (g_option = 0) then
            STRSQL := 'GRANT ' || priv || ' ON ' || obj || ' TO ' || p_user  ;
        else
            STRSQL := 'GRANT ' || priv || ' ON ' || obj || ' TO ' || p_user || ' WITH GRANT OPTION';
        END IF;
        EXECUTE IMMEDIATE(STRSQL);
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Username or role does not exist');
    END IF;
END;

--Store procedure grant quyền người dùng trên mức cột (select, update)
CREATE OR REPLACE PROCEDURE SP_GRANTPRIVUSERCOL(
    p_user IN VARCHAR2,
    priv IN VARCHAR2,
    obj IN VARCHAR2,
    colm IN VARCHAR2,
    g_option IN NUMBER
)    
AS
    v_count NUMBER;
    v_count2 NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM dba_users
    WHERE USERNAME = upper(p_user);
    SELECT COUNT(*)
    INTO v_count2
    FROM dba_roles
    WHERE ROLE = upper(p_user);
    if (v_count + v_count2) > 0 then
         if (g_option = 0) then
            STRSQL := 'GRANT ' || priv || '(' || colm || ') ' || ' ON ' || obj  || ' TO ' || p_user  ;
        else
            STRSQL := 'GRANT ' || priv || '(' || colm || ') ' || ' ON ' || obj  || ' TO ' || p_user || ' WITH GRANT OPTION';
        END IF;
        EXECUTE IMMEDIATE(STRSQL);
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Username or role does not exist');
    END IF;
END;

--Stored procedure thu hồi quyền người dùng
CREATE OR REPLACE PROCEDURE SP_REVOKEPRIVUSER(
    p_user IN VARCHAR2,
    priv IN VARCHAR2,
    obj IN VARCHAR2    
)    
AS
    v_count NUMBER;
    v_count2 NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM dba_users
    WHERE USERNAME = upper(p_user);
    SELECT COUNT(*)
    INTO v_count2
    FROM dba_roles
    WHERE ROLE = upper(p_user);
    if (v_count + v_count2) > 0 then
        STRSQL := 'REVOKE ' || priv || ' ON ' || obj || ' FROM ' || p_user  ;
        EXECUTE IMMEDIATE(STRSQL);
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Username or role does not exist');
    END IF;
END;