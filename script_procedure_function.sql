-------------------------------PHÂN HỆ 1------------------------
--stored procedure tạo user
select * from ADMIN.DANGKY;
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
/
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
/
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
/
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
/
--Store procedure grant quyền người dùng trên mức cột (update)
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
/
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
--Stored Procedure kiểm tra quyền của người dùng
create or replace PROCEDURE SP_CHECKPRIV
(p_username in varchar2,
c2 out sys_refcursor)
AUTHID CURRENT_USER AS
    l_check NVARCHAR2(20) := upper(p_username);
BEGIN
    open c2 for
    SELECT * from USER_TAB_PRIVS  where GRANTEE= l_check;
    --dbms_sql.return_result(c2);
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
--Stored Procedure kiểm tra role của người dùng
create or replace PROCEDURE SP_CHECKROLE
(p_username in varchar2,
c2 out sys_refcursor)
AUTHID CURRENT_USER AS
    l_check NVARCHAR2(20) := upper(p_username);
BEGIN
    open c2 for
    SELECT * from DBA_ROLE_PRIVS  where GRANTEE= l_check;
    --dbms_sql.return_result(c2);
END;
/
------------------------------------------PHÂN HỆ 2---------------------------------------
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

DROP ROLE NVCOBAN;
DROP ROLE GIANGVIEN;
DROP ROLE GIAOVU;
DROP ROLE TRUONGDV;
DROP ROLE TRUONGKHOA;
DROP ROLE SINHVIEN;

--Tạo role trong hệ thống
CREATE ROLE NVCOBAN;
CREATE ROLE GIANGVIEN;
CREATE ROLE GIAOVU;
CREATE ROLE TRUONGDV;
CREATE ROLE TRUONGKHOA;
CREATE ROLE SINHVIEN;
select * from admin.NHANSU
--GRANT quyền theo yêu cầu 

GRANT UPDATE(DT) ON NHANSU TO NVCOBAN,GIANGVIEN,GIAOVU,TRUONGDV, TRUONGKHOA;
GRANT SELECT ON NHANSU TO NVCOBAN, GIANGVIEN, GIAOVU, TRUONGDV, TRUONGKHOA;
GRANT SELECT ON SINHVIEN TO NVCOBAN, GIANGVIEN, TRUONGDV;
GRANT SELECT ON DONVI TO NVCOBAN, GIANGVIEN, TRUONGDV;
GRANT SELECT ON HOCPHAN TO NVCOBAN, GIANGVIEN, TRUONGDV;
GRANT SELECT ON KHMO TO NVCOBAN, GIANGVIEN, TRUONGDV;
GRANT SELECT ON PHANCONG TO GIANGVIEN, TRUONGDV, TRUONGKHOA;
GRANT SELECT,UPDATE(DIEMTHI, DIEMQT, DIEMCK, DIEMTK) ON DANGKY TO GIANGVIEN, TRUONGDV, TRUONGKHOA;
GRANT SELECT, INSERT, UPDATE ON SINHVIEN TO GIAOVU;
GRANT SELECT, INSERT, UPDATE ON DONVI TO GIAOVU;
GRANT SELECT, INSERT, UPDATE ON HOCPHAN TO GIAOVU;
GRANT SELECT, INSERT, UPDATE ON KHMO TO GIAOVU;
GRANT SELECT, UPDATE ON PHANCONG TO GIAOVU;
GRANT SELECT,INSERT, DELETE ON DANGKY TO GIAOVU;
GRANT INSERT, UPDATE, DELETE ON PHANCONG TO TRUONGDV, TRUONGKHOA;
GRANT INSERT, UPDATE, DELETE ON NHANSU TO TRUONGKHOA;
GRANT SELECT ANY TABLE TO TRUONGKHOA;
GRANT SELECT, UPDATE(DCHI, DT) ON SINHVIEN TO SINHVIEN;
GRANT SELECT ON HOCPHAN TO SINHVIEN;
GRANT SELECT ON KHMO TO SINHVIEN;
GRANT SELECT, INSERT, DELETE  ON DANGKY TO SINHVIEN;
GRANT SELECT ON ADMIN.view_add_phancong TO TRUONGKHOA, TRUONGDV;
GRANT SELECT  ON view_decrypted_nhansu TO NVCOBAN,GIANGVIEN,GIAOVU,TRUONGDV, TRUONGKHOA;
--Procedure tạo tài khoản user cho NHANSU
CREATE OR REPLACE PROCEDURE USP_CREATE_STAFF_USER
AS
    CURSOR CUR IS (SELECT MANV
                    FROM ADMIN.NHANSU
                    WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS ));
    STRSQL VARCHAR2(1000);
    USR VARCHAR2(20);
BEGIN 
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;

        STRSQL := 'CREATE USER ' || USR || ' IDENTIFIED BY ' || USR;

        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT CONNECT TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
EXECUTE USP_CREATE_STAFF_USER;
/
--Procedure tạo tài khoản user cho SINHVIEN
CREATE OR REPLACE PROCEDURE USP_CREATE_STUDENT_USER
AS
    CURSOR CUR IS (SELECT MASV
                    FROM SINHVIEN
                    WHERE MASV NOT IN (SELECT USERNAME FROM ALL_USERS));
    STRSQL VARCHAR2(1000);
    USR VARCHAR2(20);
BEGIN 
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;

        STRSQL := 'CREATE USER ' || USR || ' IDENTIFIED BY ' || USR;

        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT CONNECT TO ' || USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
EXECUTE USP_CREATE_STUDENT_USER;
/
--Procedure gán role nhân viên tương ứng cho NHANSU
CREATE OR REPLACE PROCEDURE USP_ADD_ROLE_STAFF
AS
    CURSOR CUR IS (SELECT MANV, VAITRO
                    FROM NHANSU);
    STRSQL VARCHAR(1000);
    USR VARCHAR2(20);
    VT NVARCHAR2(50);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR, VT;
        EXIT WHEN CUR%NOTFOUND;
        IF VT = N'Nhân viên cơ bản' THEN
        STRSQL := 'GRANT NVCOBAN TO '||USR;
        EXECUTE IMMEDIATE (STRSQL);
        ELSIF VT = N'Giảng viên' THEN
        STRSQL := 'GRANT GIANGVIEN TO ' || USR;
        EXECUTE IMMEDIATE (STRSQL);
        ELSIF VT = N'Giáo vụ' THEN
        STRSQL := 'GRANT GIAOVU TO ' || USR;
        EXECUTE IMMEDIATE (STRSQL);
        ELSIF VT = N'Trưởng đơn vị' THEN
        STRSQL := 'GRANT TRUONGDV TO ' || USR;
        EXECUTE IMMEDIATE (STRSQL);
        ELSIF VT = N'Trưởng khoa' THEN
        STRSQL := 'GRANT TRUONGKHOA TO ' || USR;
        EXECUTE IMMEDIATE (STRSQL);
        END IF;
    END LOOP;
    CLOSE CUR;
END;
/
EXECUTE USP_ADD_ROLE_STAFF;


--Procedure gán role cho SINHVIEN
CREATE OR REPLACE PROCEDURE USP_ADD_ROLE_STUDENT
AS
    CURSOR CUR IS (SELECT MASV
                    FROM SINHVIEN);
    STRSQL VARCHAR(1000);
    USR VARCHAR2(20);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'GRANT SINHVIEN TO ' || USR;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
EXECUTE USP_ADD_ROLE_STUDENT;
/



----------------------------------------------VPD-------------------------------------------------
--------------------------------
--VPD BẢNG NHANSU
--Thao tác SELECT và UPDATE
CREATE OR REPLACE FUNCTION F_VPD_SELECT_UPDATE_NHANSU(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
    position NVARCHAR2(50);
BEGIN
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        SELECT VAITRO INTO position FROM NHANSU WHERE MANV = user;
        IF (position = N'Nhân viên cơ bản' OR position = N'Giảng viên' OR position = N'Trưởng đơn vị' OR position = N'Giáo vụ' ) THEN 
            RETURN 'MANV = ''' || user || ''''; 
        ELSIF (position = N'Trưởng khoa') THEN
            RETURN '';
        ELSE 
            RETURN '1=0';
        END IF;
    END IF;
END;
/
CREATE OR REPLACE FUNCTION F_VPD_SELECT_NHANSU_DONVI(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
    position NVARCHAR2(50);
    dv NVARCHAR2(20);
BEGIN
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        SELECT VAITRO,MADV INTO position,dv FROM NHANSU WHERE MANV = user;
        IF (position = N'Nhân viên cơ bản' OR position = N'Giảng viên'  ) THEN 
            RETURN 'MANV = ''' || user || ''''; 
        ELSIF(position=N'Trưởng đơn vị' OR position = N'Giáo vụ') THEN 
            RETURN 'MADV = '''||dv||'''';
        ELSIF (position = N'Trưởng khoa') THEN
            RETURN '';
        ELSE 
            RETURN '1=0';
        END IF;
    END IF;
END;
/
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'NHANSU',
        policy_name => 'PLC_SELECT_NHANSU_DONVI',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_NHANSU_DONVI',
        statement_types => 'SELECT' );
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'NHANSU',
--        policy_name   => 'PLC_SELECT_NHANSU_DONVI'
--    );
--END;
--/
GRANT SELECT ON ADMIN.NHANSU TO TRUONGDV;
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'view_decrypted_nhansu',
        policy_name => 'PLC_SELECT_NHANSU',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_UPDATE_NHANSU',
        statement_types => 'SELECT');
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'view_decrypted_nhansu',
--        policy_name   => 'PLC_SELECT_NHANSU'
--    );
--END;
--/
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'NHANSU',
        policy_name => 'PLC_UPDATE_NHANSU',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_UPDATE_NHANSU',
        statement_types => 'UPDATE');
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'NHANSU',
--        policy_name   => 'PLC_UPDATE_NHANSU'
--    );
--END;
--/

--------------------------------------
--VPD BẢNG PHÂN CÔNG
--Thao tác SELECT
CREATE OR REPLACE FUNCTION F_VPD_SELECT_PHANCONG(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
    position NVARCHAR2(50);
    list_mahp VARCHAR2(500);
    CURSOR CUR IS(SELECT MAHP
    FROM HOCPHAN
    WHERE MADV =(SELECT MADV FROM ADMIN.view_decrypted_nhansu WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')));
    TEMP VARCHAR2(50);
BEGIN
    list_mahp := '';

    OPEN CUR;
    LOOP 
    FETCH CUR INTO TEMP;
        EXIT WHEN CUR%NOTFOUND;
        list_mahp := CONCAT(list_mahp,TEMP);
    END LOOP;
    CLOSE CUR;
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        SELECT VAITRO INTO position FROM ADMIN.view_decrypted_nhansu WHERE MANV = user;
        IF (position = N'Giảng viên') THEN 
            RETURN 'MAGV = '''||  user || '''';
        ELSIF (position = N'Trưởng đơn vị') THEN
            RETURN 'INSTR('''|| list_mahp ||''',MAHP) > 0 OR MAGV = ''' || user || '''';
        ELSIF (position = N'Giáo vụ' OR position = N'Trưởng khoa') THEN
            RETURN '1 != 0';
        ELSE
            RETURN '1=0';
        END IF;
    END IF;
END;
/
select * from ADMIN.PHANCONG;
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'PHANCONG',
        policy_name => 'PLC_SELECT_PHANCONG',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_PHANCONG',
        statement_types => 'SELECT');
END;
/
--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'PHANCONG',
--        policy_name   => 'PLC_SELECT_PHANCONG'
--    );
--END;
/
--Thao tác INSERT, UPDATE, DELETE
CREATE OR REPLACE FUNCTION F_VPD_UPDATE_INSERT_DELETE_PHANCONG(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
    position NVARCHAR2(50);
    list_mahp VARCHAR2(200);
    list_mahp2 VARCHAR2(400);
    TEMP VARCHAR2(50);
    CURSOR CUR IS(SELECT MAHP
                FROM HOCPHAN
                WHERE MADV =(SELECT MADV FROM NHANSU WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')));
    CURSOR CUR2 IS(SELECT PC.MAHP
                    FROM PHANCONG PC JOIN HOCPHAN HP
                    ON PC.MAHP=HP.MAHP
                    JOIN DONVI DV 
                    ON HP.MADV=DV.MADV AND DV.TENDV=N'Văn phòng khoa');                   
BEGIN
    list_mahp := '';
    list_mahp2:= '';
    OPEN CUR;
    LOOP 
        FETCH CUR INTO TEMP;
            EXIT WHEN CUR%NOTFOUND;
            list_mahp := list_mahp || TEMP;
    END LOOP;
    CLOSE CUR;
    
    OPEN CUR2;
        LOOP 
            FETCH CUR2 INTO TEMP;
                EXIT WHEN CUR2%NOTFOUND;
                list_mahp2 := list_mahp2 || TEMP;
        END LOOP;
    CLOSE CUR2;
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        SELECT VAITRO INTO position FROM ADMIN.NHANSU WHERE MANV = user;
        IF (position = N'Trưởng đơn vị') THEN 
            RETURN 'INSTR('''|| list_mahp ||''',MAHP) > 0 OR MAGV = ''' || user || '''';
        ELSIF (position = N'Giáo vụ' OR position = N'Trưởng khoa') THEN
            RETURN 'INSTR('''|| list_mahp2 ||''',MAHP) > 0 OR MAGV = ''' || user || '''';
        ELSE
            RETURN '1=0';
        END IF;
    END IF;
END;
/

BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'PHANCONG',
        policy_name => 'PLC_UPDATE_INSERT_DELETE_PHANCONG',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_UPDATE_INSERT_DELETE_PHANCONG',
        statement_types => 'INSERT,UPDATE,DELETE',
        UPDATE_CHECK=>TRUE);
END;

--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'PHANCONG',
--        policy_name   => 'PLC_UPDATE_INSERT_DELETE_PHANCONG'
--    );
--END;
/
--------------------------------------
--VPD BẢNG KHMO
--Thao tác SELECT
CREATE OR REPLACE FUNCTION F_VPD_SELECT_KHMO(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS               
    CTDT VARCHAR2(30);
    VAITRO VARCHAR(20);
    current_user VARCHAR2(20);
BEGIN
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        current_user := SYS_CONTEXT('USERENV', 'SESSION_USER');     
        IF (INSTR(user, 'SV') > 0) THEN 
            SELECT MACT INTO CTDT FROM ADMIN.SINHVIEN WHERE MASV = current_user;
            RETURN 'MACT = '''||CTDT||'''';
        ELSE
            RETURN '1=1';
        END IF;
    END IF;
END;
/
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'KHMO',
        policy_name => 'PLC_SELECT_KHMO',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_KHMO',
        statement_types => 'SELECT');
END;

--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'KHMO',
--        policy_name   => 'PLC_SELECT_KHMO'
--    );
--END;
/
----------------------------
--VPD bảng DANGKY
--Thao tác SELECT
CREATE OR REPLACE FUNCTION F_VPD_SELECT_DANGKY(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
    position NVARCHAR2(50);
BEGIN
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        position := '';
        user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        IF(INSTR(user, 'SV') > 0) THEN RETURN 'MASV = ''' || user || ''''; END IF;
            SELECT VAITRO INTO position FROM NHANSU WHERE MANV = user;
        IF (position = N'Giảng viên' OR position = N'Trưởng đơn vị') THEN 
            RETURN 'MAGV = ''' || user || ''''; 
        ELSIF (position = N'Giáo vụ' OR position = N'Trưởng khoa') THEN
            RETURN '';
        ELSE
            RETURN '1=0';
        END IF;
    END IF;
END;
/
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'DANGKY',
        policy_name => 'PLC_SELECT_DANGKY',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_DANGKY',
        statement_types => 'SELECT',
        update_check => TRUE );
END;

--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'DANGKY',
--        policy_name   => 'PLC_SELECT_DANGKY'
--    );
--END;
/
--Thao tác UPDATE
CREATE OR REPLACE FUNCTION F_VPD_UPDATE_DANGKY(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
BEGIN
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN '1 != 0';
    ELSE 
        user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        RETURN 'MAGV = ''' || user || ''''; 
    END IF;
END;
/
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'DANGKY',
        policy_name => 'PLC_UPDATE_DANGKY',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_UPDATE_DANGKY',
        statement_types => 'UPDATE',
        update_check => TRUE );
END;

--BEGIN
--   DBMS_RLS.DROP_POLICY (
--       object_schema => 'ADMIN',
--        object_name   => 'DANGKY',
--        policy_name   => 'PLC_UPDATE_DANGKY'
--   );
--END;
/
--Thao tác INSERT, DELETE
CREATE OR REPLACE FUNCTION F_VPD_INSERT_DELETE_DANGKY(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    position NVARCHAR2(50);
    user VARCHAR(100);
    filter VARCHAR2(4000);
    current_year VARCHAR2(4);
    current_date DATE := SYSDATE;
BEGIN
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN '1 != 0';
    ELSE 
         user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        SELECT VAITRO INTO position FROM ADMIN.view_decrypted_nhansu where MANV=SYS_CONTEXT('USERENV', 'SESSION_USER');
        IF (position = N'Giáo vụ') THEN 
            current_year := TO_CHAR(current_date, 'YYYY');
            filter := '';
            
            IF TO_CHAR(current_date, 'MM-DD') BETWEEN '01-01' AND '01-14' THEN
                filter := filter || 'HK = ''1'' AND NAM = ''' || current_year || '''';
            ELSIF TO_CHAR(current_date, 'MM-DD') BETWEEN '05-01' AND '05-14' THEN
                filter := filter || 'HK = ''2'' AND NAM = ''' || current_year || '''';
            ELSIF TO_CHAR(current_date, 'MM-DD') BETWEEN '09-01' AND '09-15' THEN
                filter := filter || 'HK = ''3'' AND NAM = ''' || current_year || '''';
            ELSE
                RETURN '1=0'; -- Không trả về giá trị nếu không thuộc các khoảng thời gian trên
            END IF;
            
            RETURN filter;       
        -- Kiểm tra vai trò nhân viên
        ELSE
            RETURN '1=0';
        END IF;
    END IF;
END;
/


BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'DANGKY',
        policy_name => 'PLC_INSERT_DELETE_DANGKY',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_INSERT_DELETE_DANGKY',
        statement_types => 'INSERT, DELETE',
        update_check => TRUE );
END;

-- BEGIN
--     DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--         object_name   => 'DANGKY',
--         policy_name   => 'PLC_INSERT_DELETE_DANGKY'
--     );
-- END;
/

--------------------------------------
--VPD BẢNG HOCPHAN
--Thao tác SELECT
CREATE OR REPLACE FUNCTION F_VPD_SELECT_HOCPHAN(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS               
    HP VARCHAR2(30);
    list_hp VARCHAR2(200);
    VAITRO VARCHAR(20);
    current_user VARCHAR(20);
    CURSOR CUR IS(SELECT HP.MAHP
        FROM ADMIN.SINHVIEN SV JOIN ADMIN.KHMO KHMO
        ON SV.MACT=KHMO.MACT
        JOIN ADMIN.HOCPHAN HP ON KHMO.MAHP=HP.MAHP
        WHERE SV.MASV=SYS_CONTEXT('USERENV', 'SESSION_USER'));
BEGIN
    current_user:=SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        list_hp:='';
        current_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        IF (INSTR(user, 'SV') > 0) THEN 
            OPEN CUR;
            LOOP 
                FETCH CUR INTO HP;
                EXIT WHEN CUR%NOTFOUND;
                    list_hp:=list_hp||HP;
            END LOOP;
            CLOSE CUR;
            RETURN 'INSTR('''||list_hp||''',MAHP)>0';
        ELSE
            RETURN '1=1';
        END IF;
    END IF;
END;
/

BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'HOCPHAN',
        policy_name => 'PLC_SELECT_HOCPHAN',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_HOCPHAN',
        statement_types => 'SELECT');
END;

--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'HOCPHAN',
--        policy_name   => 'PLC_SELECT_HOCPHAN'
--    );
--END;
/
----------------------------------
--VPD bảng SINHVIEN
--Thao tác SELECT, UPDATE
CREATE OR REPLACE FUNCTION F_VPD_SELECT_UPDATE_SINHVIEN(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR(100);
BEGIN
    IF ( SYS_CONTEXT('USERENV', 'ISDBA') = 'TRUE' ) THEN
        RETURN ' 1 != 0';
    ELSE 
        user := SYS_CONTEXT('USERENV', 'SESSION_USER');
        IF (INSTR(user, 'SV') > 0) THEN 
            RETURN 'MASV = ''' || user || ''''; 
        ELSE
            RETURN ' 1 != 0 ';
        END IF;
    END IF;
END;
/
BEGIN
    dbms_rls.add_policy (
        object_schema => 'ADMIN',
        object_name => 'SINHVIEN',
        policy_name => 'PLC_SELECT_UPDATE_SINHVIEN',
        function_schema => 'ADMIN',
        policy_function => 'F_VPD_SELECT_UPDATE_SINHVIEN',
        statement_types => 'SELECT, UPDATE',
        update_check => TRUE );
END;
/

--BEGIN
--    DBMS_RLS.DROP_POLICY (
--        object_schema => 'ADMIN',
--        object_name   => 'SINHVIEN',
--        policy_name   => 'PLC_SELECT_UPDATE_SINHVIEN'
--    );
--END;
/
-------------------------------------OLS----------------------------------------
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE

-- KIỂM TRA OLS ĐÃ ĐƯỢC BẬT CHƯA (CONNECT = SYS USER) 
SELECT VALUE FROM v$option WHERE parameter = 'Oracle Label Security'; 
SELECT status FROM dba_ols_status WHERE name = 'OLS_CONFIGURE_STATUS';

-- BẬT OLS NẾU CHƯA BẬT/ CHƯA ĐĂNG KÝ THÌ ĐĂNG KÝ OLS VÀ BẬT OLS
EXEC LBACSYS.CONFIGURE_OLS; -- ĐK OLS
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; -- BẬT OLS

-- KHỞI ĐỘNG LẠI
SHUTDOWN IMMEDIATE; 
STARTUP
-- KIỂM TRA PDB CÓ CHƯA (VÌ KO THỂ TẠO OLS TREN CDB) 
SELECT * FROM V$SERVICES;

-- UNLOCK LBACSYS (OLS ADMIN)
ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;

-- NẾU CÓ RỒI THÌ MỞ PDB 
ALTER PLUGGABLE DATABASE PDBQLDLNB OPEN READ WRITE;
SELECT * FROM V$PDBS;

-- CHUYỂN QUA PDB
ALTER SESSION SET CONTAINER = PDB_QLTB; 
SHOW CON_NAME;


-- TẠO ADMIN OLS & CẤP QUYỀN CHO ADMIN 
CREATE USER ADMIN_OLS IDENTIFIED BY ADMIN_OLS CONTAINER = CURRENT;
GRANT CREATE SESSION TO ADMIN_OLS CONTAINER = CURRENT;
GRANT CONNECT, RESOURCE TO ADMIN_OLS; --CẤP QUYỀN CONNECT VÀ RESOURCE 
GRANT UNLIMITED TABLESPACE TO ADMIN_OLS; --CẤP QUOTA CHO ADMIN_OLS 
GRANT SELECT ANY DICTIONARY TO ADMIN_OLS; --CẤP QUYỀN ĐỌC DICTIONARY 
GRANT SELECT ON ADMIN.NHANSU to ADMIN_OLS;
GRANT SELECT ON ADMIN.SINHVIEN to ADMIN_OLS;

-- CẤP QUYỀN EXECUTE CHO ADMIN 
GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON LBACSYS.sa_user_admin TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON LBACSYS.sa_label_admin TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON sa_policy_admin TO ADMIN_OLS WITH GRANT OPTION; 
GRANT EXECUTE ON char_to_label TO ADMIN_OLS WITH GRANT OPTION; 

-- ADD ADMIN VÀO LBAC_DBA 
GRANT LBAC_DBA TO ADMIN_OLS; 
GRANT EXECUTE ON sa_sysdba TO ADMIN_OLS; 
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO ADMIN_OLS; -- CẤP QUYỀN THỰC THI

BEGIN 
    SA_SYSDBA.DROP_POLICY( 
    POLICY_NAME => 'HCMUS_POLICY', 
    DROP_COLUMN  => TRUE
    ); 
END; 

-- TẠO CHÍNH SÁCH OLS (KHỞI ĐỘNG LẠI SQLDEV ĐỂ CẬP NHẬT OLS ENABLE) 
BEGIN 
    SA_SYSDBA.CREATE_POLICY( 
    POLICY_NAME => 'HCMUS_POLICY', 
    COLUMN_NAME => 'HCMUS_LABEL'
    ); 
END; 

--ENABLE POLICY VỪA TẠO -> KHOI DONG LẠI SQLDEV 
EXEC SA_SYSDBA.ENABLE_POLICY ('HCMUS_POLICY'); 
show con_name
-- TẠO COMPONENT CỦA LABEL 
---> TẠO LEVEL 
EXECUTE SA_COMPONENTS.CREATE_LEVEL('HCMUS_POLICY',60,'TK','Truong khoa');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('HCMUS_POLICY',50,'TDV','Truong don vi');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('HCMUS_POLICY',40,'GV','Giang vien');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('HCMUS_POLICY',30,'GVu','Giao vu');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('HCMUS_POLICY',20,'NV','Nhan vien');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('HCMUS_POLICY',10,'SV','Sinh vien');

---> TẠO COMPARTMENT 
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('HCMUS_POLICY',160,'HTTT','He thong thong tin');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('HCMUS_POLICY',150,'CNPM','Cong nghe phan mem');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('HCMUS_POLICY',140,'KHMT','Khoa hoc may tinh');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('HCMUS_POLICY',130,'CNTT','Cong nghe thong tin');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('HCMUS_POLICY',120,'TGMT','Thi giac may tinh');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('HCMUS_POLICY',110,'MMT','Mang may tinh');

---> TẠO GROUP 
EXECUTE SA_COMPONENTS.CREATE_GROUP('HCMUS_POLICY',60,'TT','Toan truong'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP('HCMUS_POLICY',40,'CS1','Co so 1', 'TT'); 
EXECUTE SA_COMPONENTS.CREATE_GROUP('HCMUS_POLICY',20,'CS2','Co so 2', 'TT');

-- TẠO BẢNG DỮ LIỆU
DROP TABLE OLS_THONGBAO
CREATE TABLE OLS_THONGBAO 
( 
    MATB CHAR(10) PRIMARY KEY, 
    TEN NVARCHAR2(100), 
    NOIDUNG NVARCHAR2(200)
);

-- THÊM DỮ LIỆU VÀO BẢNG
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T1', N'Thông báo cho Trưởng đơn vị', N'Đây là thông báo dành cho tất cả các Trưởng đơn vị');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T2', N'Thông báo cho Sinh viên', N'Đây là thông báo dành cho Sinh viên HTTT học ở cơ sở 1');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T3', N'Thông báo cho Trưởng bộ môn', N'Đây là thông báo dành cho Trưởng bộ môn KHMT ở cơ sở 1');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T4', N'Thông báo cho Trưởng bộ môn', N'Đây là thông báo dành cho Trưởng bộ môn KHMT ở cả 2 cơ sở');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T5', N'Thông báo cho Sinh viên', N'Đây là thông báo chung dành cho tất cả Sinh viên');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T6', N'Thông báo cho Sinh viên', N'Đây là thông báo dành cho Sinh viên CNTT học ở cơ sở 1');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T7', N'Thông báo cho Giảng viên', N'Đây là thông báo dành cho Giảng viên KHMT');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T8', N'Thông báo cho Giảng viên', N'Đây là thông báo dành cho tất cả Giảng viên ở cơ sở 2');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T9', N'Thông báo cho Giáo vụ', N'Đây là thông báo dành cho Giáo vụ CNTT');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T10', N'Thông báo cho Giáo vụ', N'Đây là thông báo dành cho Giáo vụ MMT ở cơ sở 1');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T11', N'Thông báo cho Nhân viên', N'Đây là thông báo dành cho tất cả Nhân viên');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T12', N'Thông báo cho Nhân viên', N'Đây là thông báo dành cho Nhân viên ở cơ sở 2');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T13', N'Thông báo cho Trưởng khoa', N'Đây là thông báo dành chỉ dành cho Trưởng khoa');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T14', N'Thông báo cho Sinh viên', N'Đây là thông báo dành cho Sinh viên ở cơ sở 2');
INSERT INTO OLS_THONGBAO(MATB, TEN, NOIDUNG)
VALUES('T15', N'Thông báo cho Giảng viên', N'Đây là thông báo dành cho Giảng viên CNTT');

-- KIỂM TRA DỮ LIỆU ĐÃ ĐƯỢC THÊM VÀO
SELECT * FROM OLS_THONGBAO;

-- TẠO NHÃN
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1010, 'TDV'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1020, 'SV:HTTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1030, 'TDV:KHMT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1040, 'TDV:KHMT'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1050, 'SV'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1060, 'SV:CNTT:CS1'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1070, 'GV:KHMT'); 
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1080, 'GV::CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1090, 'GVu:CNTT');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1100, 'GVu:MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1110, 'NV');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1120, 'NV::CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1130, 'TK');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1140, 'SV::CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('HCMUS_POLICY', 1150, 'GV:CNTT');

-- CẬP NHẬT NHÃN TRONG BẢNG
BEGIN 
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY ( 
    POLICY_NAME => 'HCMUS_POLICY',
    SCHEMA_NAME => 'ADMIN_OLS', 
    TABLE_NAME => 'OLS_THONGBAO',
    TABLE_OPTIONS => 'NO_CONTROL'
 ); 
END; 

-- TẠO NHÃN THỦ CÔNG BẰNG LỆNH 
UPDATE OLS_THONGBAO 
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','TDV') 
WHERE MATB = 'T1';
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','SV:HTTT:CS1') 
WHERE MATB = 'T2';
UPDATE OLS_THONGBAO 
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','TDV:KHMT:CS1') 
WHERE MATB = 'T3'; 
UPDATE OLS_THONGBAO 
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','TDV:KHMT')
WHERE MATB = 'T4'; 
UPDATE OLS_THONGBAO 
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','SV')
WHERE MATB = 'T5'; 
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','SV:HTTT:CS1')
WHERE MATB = 'T6'; 
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','GV:KHMT') 
WHERE MATB = 'T7'; 
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','GV::CS2') 
WHERE MATB = 'T8';
UPDATE OLS_THONGBAO 
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','GVu:CNTT')
WHERE MATB = 'T9'; 
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','GVu:MMT:CS1')
WHERE MATB = 'T10'; 
UPDATE OLS_THONGBAO 
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','NV') 
WHERE MATB = 'T11';
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','NV::CS2')
WHERE MATB = 'T12'; 
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','TK') 
WHERE MATB = 'T13'; 
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','SV::CS2') 
WHERE MATB = 'T14';
UPDATE OLS_THONGBAO
SET HCMUS_LABEL = CHAR_TO_LABEL('HCMUS_POLICY','GV:CNTT')
WHERE MATB = 'T15';

-- KIỂM TRA NHÃN ĐÃ ĐƯỢC THÊM VÀO BẢNG HAY CHƯA
SELECT MATB, TEN, NOIDUNG, LABEL_TO_CHAR(HCMUS_LABEL) FROM OLS_THONGBAO;

-- GỠ CHÍNH SÁCH KHỎI BẢNG VÀ ÁP DỤNG LẠI
BEGIN
    SA_POLICY_ADMIN.REMOVE_TABLE_POLICY(
    POLICY_NAME => 'HCMUS_POLICY',
    SCHEMA_NAME => 'ADMIN_OLS', 
    TABLE_NAME => 'OLS_THONGBAO'
);
END;

BEGIN
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
    POLICY_NAME => 'HCMUS_POLICY',
    SCHEMA_NAME => 'ADMIN_OLS', 
    TABLE_NAME => 'OLS_THONGBAO',
    TABLE_OPTIONS => 'READ_CONTROL',
    PREDICATE => NULL
);
END;

--PROCEDURE THỰC HIỆN GÁN NHÃN CHO CÁC NHÂN VIÊN
CREATE OR REPLACE PROCEDURE SET_NHANSU_LABEL
AS
    CURSOR CUR IS (SELECT MANV, VAITRO, MADV, COSO FROM ADMIN.NHANSU);
    STRSQL VARCHAR(2000); 
    U_LABEL VARCHAR2(100);
    REC CUR%ROWTYPE;
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO REC;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'GRANT SELECT ON ADMIN_OLS.OLS_THONGBAO TO ' || REC.MANV;
        EXECUTE IMMEDIATE(STRSQL);
        CASE REC.VAITRO
            WHEN N'Trưởng khoa' THEN
                U_LABEL := 'TK:';
            WHEN N'Trưởng đơn vị' THEN
                U_LABEL := 'TDV:';
            WHEN N'Giảng viên' THEN 
                U_LABEL := 'GV:';
            WHEN N'Nhân viên cơ bản' THEN
                U_LABEL := 'NV:';
            WHEN N'Giáo vụ' THEN
                U_LABEL := 'GVu:';
            ELSE
                U_LABEL := 'ERROR';
        END CASE;
        CASE REC.MADV
            WHEN 'VPK' THEN
                U_LABEL := U_LABEL || 'HTTT,CNPM,KHMT,MMT,TGMT,CNTT:';
            WHEN 'CNPM' THEN
                U_LABEL := U_LABEL || 'CNPM:';
            WHEN 'HTTT' THEN
                U_LABEL := U_LABEL || 'HTTT:';
            WHEN 'CNTT' THEN
                U_LABEL := U_LABEL || 'CNTT:';
            WHEN 'TGMT' THEN
                U_LABEL := U_LABEL || 'TGMT:';
            WHEN 'KHMT' THEN
                U_LABEL := U_LABEL || 'KHMT:';
            WHEN 'MMT' THEN
                U_LABEL := U_LABEL || 'MMT:';
        END CASE;
        CASE REC.COSO
            WHEN 'TT' THEN
                U_LABEL := U_LABEL || 'TT';
            WHEN 'CS1' THEN
                U_LABEL := U_LABEL || 'CS1';
            WHEN 'CS2' THEN
                U_LABEL := U_LABEL || 'CS2';
        END CASE;
        STRSQL := 'BEGIN
                        SA_USER_ADMIN.SET_USER_LABELS(''HCMUS_POLICY'', ''' || REC.MANV || ''', ''' || U_LABEL || ''');
                        END;';
        DBMS_OUTPUT.PUT_LINE(STRSQL);
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
-- THỰC THI
EXECUTE SET_NHANSU_LABEL;
/
--PROCEDURE THỰC HIỆN GÁN NHÃN CHO SINH VIÊN
CREATE OR REPLACE PROCEDURE SET_SINHVIEN_LABEL
AS
    CURSOR CUR IS (SELECT MASV, MANGANH, COSO FROM ADMIN.SINHVIEN);
    STRSQL VARCHAR(2000); 
    U_LABEL VARCHAR2(100);
    REC CUR%ROWTYPE;
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO REC;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'GRANT SELECT ON ADMIN_OLS.OLS_THONGBAO TO ' || REC.MASV;
        EXECUTE IMMEDIATE(STRSQL);
        U_LABEL := 'SV:';
        CASE REC.MANGANH
            WHEN 'CNPM' THEN
                U_LABEL := U_LABEL || 'CNPM:';
            WHEN 'HTTT' THEN
                U_LABEL := U_LABEL || 'HTTT:';
            WHEN 'CNTT' THEN
                U_LABEL := U_LABEL || 'CNTT:';
            WHEN 'TGMT' THEN
                U_LABEL := U_LABEL || 'TGMT:';
            WHEN 'KHMT' THEN
                U_LABEL := U_LABEL || 'KHMT:';
            WHEN 'MMT' THEN
                U_LABEL := U_LABEL || 'MMT:';
        END CASE;
        CASE REC.COSO
            WHEN 'TT' THEN
                U_LABEL := U_LABEL || 'TT';
            WHEN 'CS1' THEN
                U_LABEL := U_LABEL || 'CS1';
            WHEN 'CS2' THEN
                U_LABEL := U_LABEL || 'CS2';
        END CASE;
        STRSQL := 'BEGIN
                        SA_USER_ADMIN.SET_USER_LABELS(''HCMUS_POLICY'', ''' || REC.MASV || ''', ''' || U_LABEL || ''');
                        END;';
        DBMS_OUTPUT.PUT_LINE(STRSQL);
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
-- THỰC THI 
EXECUTE SET_SINHVIEN_LABEL;
/
-----------------------------------------------AUDIT-------------------
--STANDARD AUDIT
--PROCEDURE TẠO AUDIT TRÊN CÁC ĐỐI TƯỢNG BẢNG
CREATE OR REPLACE PROCEDURE USP_CREATE_TABLE_AUDIT_POLICY
AS
  STRSQL VARCHAR2(1000);
  OWNE VARCHAR2(50);
  TABLE_NAME VARCHAR2(50);
  CURSOR CUR IS (SELECT owner, table_name
              FROM all_tables
             WHERE owner = 'ADMIN' and table_name != 'OLS_THONGBAO');
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO OWNE, TABLE_NAME;
        EXIT WHEN CUR%NOTFOUND;
        IF(TABLE_NAME != 'NHANSU') THEN
            STRSQL := 'CREATE AUDIT POLICY AUDIT_SELECT_' || OWNE || '_' || TABLE_NAME ||
                          ' ACTIONS SELECT ON ' || OWNE || '.' || TABLE_NAME;
            EXECUTE IMMEDIATE (STRSQL);
        ELSE 
            STRSQL := 'CREATE AUDIT POLICY AUDIT_SELECT_' || OWNE || '_' || TABLE_NAME ||
                          ' ACTIONS SELECT ON ' || OWNE || '.view_decrypted_nhansu';
            EXECUTE IMMEDIATE (STRSQL);
        end if;
        STRSQL := 'CREATE AUDIT POLICY AUDIT_UPDATE_' || OWNE || '_' || TABLE_NAME ||
                      ' ACTIONS UPDATE ON ' || OWNE || '.' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'CREATE AUDIT POLICY AUDIT_INSERT_' || OWNE || '_' || TABLE_NAME ||
                      ' ACTIONS INSERT ON ' || OWNE || '.' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'CREATE AUDIT POLICY AUDIT_DELETE_' || OWNE || '_' || TABLE_NAME ||
                      ' ACTIONS DELETE ON ' || OWNE || '.' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
--THỰC THI 
EXEC USP_CREATE_TABLE_AUDIT_POLICY;
/
--PROCEDURE TẠO AUDIT TRÊN CÁC ĐỐI TƯỢNG PROCEDURE
CREATE OR REPLACE PROCEDURE USP_CREATE_PROCEDURE_AUDIT_POLICY
AS
  STRSQL VARCHAR2(1000);
  OWNE VARCHAR2(50);
  OBJECT_NAME VARCHAR2(50);
  CURSOR CUR IS (SELECT OWNER, OBJECT_NAME
            FROM ALL_OBJECTS
         WHERE OBJECT_TYPE = 'PROCEDURE' AND OWNER = 'ADMIN' );
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO OWNE, OBJECT_NAME;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'CREATE AUDIT POLICY AUDIT_EXECUTE_' || OWNE || '_' || OBJECT_NAME ||
                      ' ACTIONS EXECUTE ON ' || OWNE || '.' || OBJECT_NAME;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
EXEC USP_CREATE_PROCEDURE_AUDIT_POLICY;
/
--Procedure enable các standard audit vừa tạo trên cơ sỡ dữ liệu
CREATE OR REPLACE PROCEDURE USP_ENABLE_TABLE_AUDIT_POLICY
AS
  STRSQL VARCHAR2(1000);
  OWNE VARCHAR2(50);
  TABLE_NAME VARCHAR2(50);
  CURSOR CUR IS (SELECT owner, table_name
              FROM all_tables
             WHERE owner = 'ADMIN' and table_name != 'OLS_THONGBAO');
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO OWNE, TABLE_NAME;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'AUDIT POLICY AUDIT_SELECT_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'AUDIT POLICY AUDIT_UPDATE_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'AUDIT POLICY AUDIT_INSERT_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'AUDIT POLICY AUDIT_DELETE_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
--THỰC THI
EXEC USP_ENABLE_TABLE_AUDIT_POLICY;
/
--PROCEDURE ENABLE AUDIT TRÊN CÁC ĐỐI TƯỢNG Procedure
CREATE OR REPLACE PROCEDURE USP_ENABLE_PROCEDURE_AUDIT_POLICY
AS
  STRSQL VARCHAR2(1000);
  OWNE VARCHAR2(50);
  OBJECT_NAME VARCHAR2(50);
  CURSOR CUR IS (SELECT OWNER, OBJECT_NAME
            FROM ALL_OBJECTS
         WHERE OBJECT_TYPE = 'PROCEDURE' AND OWNER = 'ADMIN' 
                    AND OBJECT_NAME NOT LIKE '%DISABLE_PROCEDURE%'
                    AND OBJECT_NAME NOT LIKE '%ENABLE_PROCEDURE%' );
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO OWNE, OBJECT_NAME;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'AUDIT POLICY AUDIT_EXECUTE_' || OWNE || '_' || OBJECT_NAME;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
EXEC USP_ENABLE_PROCEDURE_AUDIT_POLICY;
/
--Procedure disable các standard audit trên bảng
CREATE OR REPLACE PROCEDURE USP_DISABLE_TABLE_AUDIT_POLICY
AS
  STRSQL VARCHAR2(1000);
  OWNE VARCHAR2(50);
  TABLE_NAME VARCHAR2(50);
  CURSOR CUR IS (SELECT owner, table_name
              FROM all_tables
             WHERE owner = 'ADMIN' and table_name != 'OLS_THONGBAO');
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO OWNE, TABLE_NAME;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'NOAUDIT POLICY AUDIT_SELECT_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'NOAUDIT POLICY AUDIT_UPDATE_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'NOAUDIT POLICY AUDIT_INSERT_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
        STRSQL := 'NOAUDIT POLICY AUDIT_DELETE_' || OWNE || '_' || TABLE_NAME;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
--THỰC THI
EXEC USP_DISABLE_TABLE_AUDIT_POLICY;
/
CREATE OR REPLACE PROCEDURE USP_DISABLE_PROCEDURE_AUDIT_POLICY
AS
  STRSQL VARCHAR2(1000);
  OWNE VARCHAR2(50);
  OBJECT_NAME VARCHAR2(50);
  CURSOR CUR IS (SELECT OWNER, OBJECT_NAME
            FROM ALL_OBJECTS
         WHERE OBJECT_TYPE = 'PROCEDURE' AND OWNER = 'ADMIN' AND OBJECT_NAME NOT LIKE '%DISABLE_PROCEDURE%'
                        AND OBJECT_NAME NOT LIKE '%ENABLE_PROCEDURE%');
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO OWNE, OBJECT_NAME;
        EXIT WHEN CUR%NOTFOUND;
        STRSQL := 'NOAUDIT POLICY AUDIT_EXECUTE_' || OWNE || '_' || OBJECT_NAME;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
EXEC USP_DISABLE_PROCEDURE_AUDIT_POLICY;
/
Drop tất cả table audit 
BEGIN
  FOR policy IN (SELECT POLICY_NAME 
                 FROM AUDIT_UNIFIED_POLICIES 
                 WHERE POLICY_NAME NOT LIKE 'ORA%') LOOP
    EXECUTE IMMEDIATE 'NOAUDIT POLICY ' || policy.POLICY_NAME;
    EXECUTE IMMEDIATE 'DROP AUDIT POLICY ' || policy.POLICY_NAME;
  END LOOP;
END;

---FINE GRAINED AUDIT

-- Tạo lại toàn bộ context, package, và trigger từ đầu
-- Tạo application context
DROP CONTEXT Login_DangNhap_GV;
CREATE OR REPLACE CONTEXT Login_DangNhap_GV USING Login_DangNhap_GV_PKG;

-- Tạo package Login_DangNhap_PKG
drop package Login_DangNhap_GV_PKG
CREATE OR REPLACE PACKAGE LOGIN_DANGNHAP_GV_PKG IS 
   PROCEDURE Set_Login; 
END; 
/
-- Tạo body của package Login_DangNhap_PKG
CREATE OR REPLACE PACKAGE BODY LOGIN_DANGNHAP_GV_PKG IS
   PROCEDURE Set_Login 
   IS 
      emp_id ADMIN.NHANSU.MANV%TYPE;
      vaitro_temp ADMIN.NHANSU.VAITRO%TYPE;
   BEGIN 
      BEGIN
         -- Truy vấn để lấy MANV và VAITRO
         SELECT MANV, VAITRO INTO emp_id, vaitro_temp
         FROM ADMIN.NHANSU 
         WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');       
         -- Thiết lập context nếu VAITRO là 'Giảng viên'
         IF (vaitro_temp = N'Giảng viên') THEN
            DBMS_SESSION.SET_CONTEXT('Login_DangNhap_GV', 'ID_NS_GV', emp_id);
         END IF;
      EXCEPTION  
         WHEN NO_DATA_FOUND THEN 
            NULL; -- Xử lý khi không tìm thấy dữ liệu
         WHEN OTHERS THEN
            -- Ghi lỗi và thông báo
            RAISE_APPLICATION_ERROR(-20001, 'Error in Set_Login procedure: ' || SQLERRM);
      END;
   END;
END;
/
-- Tạo trigger Login_DangNhap_Trigger 
DROP TRIGGER Login_DangNhap_GV_Trig;
CREATE OR REPLACE TRIGGER Login_DangNhap_GV_Trig
AFTER LOGON ON DATABASE
BEGIN
   ADMIN.LOGIN_DANGNHAP_GV_PKG.Set_Login;
END;
/

BEGIN
   DBMS_FGA.ADD_POLICY(
      object_schema   => 'ADMIN',
      object_name     => 'DANGKY',
      policy_name     => 'DANGKY_SCORE_UPDATE_AUDIT',
      audit_condition => 'SYS_CONTEXT(''Login_DangNhap_GV'', ''ID_NS_GV'') IS NULL',
      audit_column    => 'DIEMTHI, DIEMQT, DIEMCK, DIEMTK',
      enable          => TRUE,
      statement_types => 'UPDATE',
      audit_column_opts => DBMS_FGA.ANY_COLUMNS,
      audit_trail     => DBMS_FGA.DB + DBMS_FGA.EXTENDED
   );
END;
/

--BEGIN
--   DBMS_FGA.DROP_POLICY(
--      object_schema   => 'ADMIN',
--      object_name     => 'DANGKY',
--      policy_name     => 'DANGKY_SCORE_UPDATE_AUDIT'
--   );
--END;
/


--Ý 2
--Tạo context NHANSU
-- Tạo context
DROP CONTEXT Login_DangNhap_NS;
CREATE OR REPLACE CONTEXT Login_DangNhap_NS USING Login_DangNhap_NS_PKG;

-- Tạo package
DROP PACKAGE Login_DangNhap_NS_PKG;
CREATE OR REPLACE PACKAGE Login_DangNhap_NS_PKG IS 
   PROCEDURE Set_Login_NS; 
END; 
/

-- Tạo body của package

CREATE OR REPLACE PACKAGE BODY Login_DangNhap_NS_PKG IS
   PROCEDURE Set_Login_NS 
   IS 
      emp_id ADMIN.NHANSU.MANV%TYPE;
   BEGIN 
      SELECT MANV INTO emp_id
      FROM ADMIN.NHANSU 
      WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
    DBMS_SESSION.SET_CONTEXT('Login_DangNhap_NS', 'ID_NS', emp_id);
   EXCEPTION  
      WHEN NO_DATA_FOUND THEN 
         NULL;
   END;
END;
/
-- Tạo trigger
DROP TRIGGER Login_DangNhap_NS_Trigger;
CREATE OR REPLACE TRIGGER Login_DangNhap_NS_Trigger 
AFTER LOGON ON DATABASE
BEGIN
   ADMIN.Login_DangNhap_NS_PKG.Set_Login_NS;
END;
/


BEGIN
   DBMS_FGA.ADD_POLICY(
      object_schema   => 'ADMIN',
      object_name     => 'view_decrypted_nhansu',
      policy_name     => 'NHANSU_SELECT_PHUCAP_AUDIT',
      audit_condition => '(MANV!=SYS_CONTEXT(''Login_DangNhap_NS'', ''ID_NS''))OR (SYS_CONTEXT(''Login_DangNhap_NS'', ''ID_NS'') IS NULL) ',
      audit_column    => 'PHUCAP',
      enable          => TRUE,
      statement_types => 'SELECT',
      audit_trail     => DBMS_FGA.DB + DBMS_FGA.EXTENDED
   );
END;

--BEGIN
--   DBMS_FGA.DROP_POLICY(
--      object_schema   => 'ADMIN',
--      object_name     => 'view_decrypted_nhansu',
--      policy_name     => 'NHANSU_SELECT_PHUCAP_AUDIT'
--   );
--END;
/

