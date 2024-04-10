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
/
--Stored Procedure tạo role
CREATE OR REPLACE PROCEDURE SP_CREATEROLE (
    p_role_name IN VARCHAR2
) AS
    v_role_count NUMBER;
BEGIN
    
    -- Kiểm tra xem role đã tồn tại chưa
    SELECT COUNT(*) INTO v_role_count FROM dba_roles WHERE role = p_role_name;
    
    IF v_role_count = 0 THEN
        -- Nếu role chưa tồn tại, tạo role mới
        EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
        EXECUTE IMMEDIATE 'CREATE ROLE ' || p_role_name;
        DBMS_OUTPUT.PUT_LINE('Role ' || p_role_name || ' created successfully.');
        EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    ELSE
        -- Nếu role đã tồn tại, thông báo lỗi
        RAISE_APPLICATION_ERROR(-20001, 'Role ' || p_role_name || ' already exists.');
    END IF;
END SP_CREATEROLE;
/
--Stored Procedure drop role
CREATE OR REPLACE PROCEDURE SP_DROPROLE(
    p_role IN VARCHAR2
)    
AS
    v_count NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count
    FROM dba_roles
    WHERE ROLE = upper(p_role);
    if v_count > 0 then
        --DBMS_OUTPUT.PUT_LINE('TEST');
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'DROP ROLE ' || p_role;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
        EXECUTE IMMEDIATE(STRSQL);
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Role does not exist');
    END IF;
END;
/
--Stored procedure grant role
CREATE OR REPLACE PROCEDURE SP_GRANTROLE(
    p_role IN VARCHAR2,
    p_username IN VARCHAR2
)    
AS
    v_count_role NUMBER;
    v_count_user NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count_role
    FROM dba_roles
    WHERE ROLE = upper(p_role);
    
    if v_count_role < 0 then
        RAISE_APPLICATION_ERROR(-20001, 'Role does not exist');
    END IF;
    
    SELECT COUNT(*)
    INTO v_count_user
    FROM dba_users
    WHERE USER = upper(p_username);
    
    if v_count_user < 0 then
        RAISE_APPLICATION_ERROR(-20001, 'User does not exist');
    END IF;
    
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT ' || p_role || ' TO ' || p_username;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
        EXECUTE IMMEDIATE(STRSQL);
END;
/
--Stored procedure revoke role
CREATE OR REPLACE PROCEDURE SP_REVOKEROLE(
    p_role IN VARCHAR2,
    p_username IN VARCHAR2
)    
AS
    v_count_role NUMBER;
    v_count_user NUMBER;
    v_count NUMBER;
    STRSQL VARCHAR(2000);
BEGIN
    SELECT COUNT(*)
    INTO v_count_role
    FROM dba_roles
    WHERE ROLE = upper(p_role);
    
    if v_count_role < 0 then
        RAISE_APPLICATION_ERROR(-20001, 'Role does not exist');
    END IF;
    
    SELECT COUNT(*)
    INTO v_count_user
    FROM dba_users
    WHERE USER = upper(p_username);
    
    if v_count_user < 0 then
        RAISE_APPLICATION_ERROR(-20001, 'User does not exist');
    END IF;
    
    SELECT COUNT(*)
    INTO v_count
    FROM dba_role_privs
    WHERE GRANTEE = upper(p_username) AND GRANTED_ROLE = upper(p_role);
    
    if v_count < 0 then
        RAISE_APPLICATION_ERROR(-20001, 'This role does not grant to user');
    END IF;
    
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'REVOKE ' || p_role || ' FROM ' || p_username;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
        EXECUTE IMMEDIATE(STRSQL);
END;
/
--Stored Procedure check role
create or replace PROCEDURE SP_CHECKROLE
(p_username in varchar2,
c2 out sys_refcursor)
AUTHID CURRENT_USER AS
    l_check NVARCHAR2(20) :=p_username;
BEGIN
    open c2 for
    SELECT * from DBA_ROLE_PRIVS  where GRANTEE= l_check;
    --dbms_sql.return_result(c2);
END;
