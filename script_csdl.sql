ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;  
show con_name

CREATE USER ADMIN IDENTIFIED BY admin;
GRANT CONNECT TO ADMIN;
GRANT SYSDBA TO ADMIN CONTAINER = ALL;
GRANT ALL PRIVILEGES TO ADMIN WITH ADMIN OPTION;
GRANT EXECUTE ANY PROCEDURE To ADMIN;
GRANT CREATE SESSION TO ADMIN CONTAINER = ALL;
GRANT CONNECT, RESOURCE,DBA TO ADMIN;
GRANT UNLIMITED TABLESPACE TO ADMIN;
GRANT SELECT ON DBA_USERS TO ADMIN;
GRANT SELECT ON DBA_ROLE_PRIVS TO ADMIN;
GRANT SELECT ON DBA_ROLES TO ADMIN;
GRANT EXECUTE ON DBMS_CRYPTO TO ADMIN;
GRANT CREATE SESSION, CREATE ANY CONTEXT, CREATE PROCEDURE, CREATE TRIGGER, ADMINISTER DATABASE TRIGGER TO ADMIN;
GRANT EXECUTE ON DBMS_SESSION TO ADMIN;
GRANT EXECUTE ON DBMS_FGA TO ADMIN;
GRANT SELECT ON DBA_FGA_AUDIT_TRAIL TO ADMIN;


--Connect dưới user admin tạo các đối tượng dữ liệu
drop view ADMIN.view_decrypted_nhansu;
drop view ADMIN.view_add_phancong;
DROP TABLE ADMIN.DANGKY;
DROP TABLE ADMIN.PHANCONG;
DROP TABLE ADMIN.KHMO;
DROP TABLE ADMIN.HOCPHAN;
DROP TABLE ADMIN.SINHVIEN;
DROP TABLE ADMIN.DONVI;
DROP TABLE ADMIN.NHANSU;
CREATE TABLE ADMIN.NHANSU (
    MANV NVARCHAR2(20) PRIMARY KEY,
    HOTEN NVARCHAR2(50),
    PHAI NVARCHAR2(10),
    NGSINH DATE,
      PHUCAP VARCHAR2(200),
    DT CHAR(10),
    VAITRO NVARCHAR2(50),
    MADV NVARCHAR2(20),
    COSO NVARCHAR2(50)
);
/
CREATE TABLE ADMIN.SINHVIEN (
    MASV NVARCHAR2(20) PRIMARY KEY,
    HOTEN NVARCHAR2(50),
    PHAI NVARCHAR2(10),
    NGSINH DATE,
    DCHI NVARCHAR2(100),
    DT CHAR(10),
    MACT NVARCHAR2(20),
    MANGANH NVARCHAR2(20),
    SOTCTL NUMBER(3),
    DTBTL NUMBER(4, 2),
    COSO NVARCHAR2(50)
);
/
CREATE TABLE ADMIN.DONVI (
    MADV NVARCHAR2(20) PRIMARY KEY,
    TENDV NVARCHAR2(50),
    TRGDV NVARCHAR2(20),
    FOREIGN KEY (TRGDV) REFERENCES ADMIN.NHANSU(MANV)
);
/
CREATE TABLE ADMIN.HOCPHAN (
    MAHP NVARCHAR2(20) PRIMARY KEY,
    TENHP NVARCHAR2(50),
    SOTC NUMBER(2),
    STLT NUMBER(2),
    STTH NUMBER(2),
    SOSVTD NUMBER(3),
    MADV NVARCHAR2(20),
    FOREIGN KEY (MADV) REFERENCES ADMIN.DONVI(MADV)
);
/
CREATE TABLE ADMIN.KHMO (
    MAHP NVARCHAR2(20),
    HK NVARCHAR2(10),
    NAM NVARCHAR2(4),
    MACT NVARCHAR2(20),
    PRIMARY KEY (MAHP, HK, NAM, MACT),
    FOREIGN KEY (MAHP) REFERENCES ADMIN.HOCPHAN(MAHP)
);
/
CREATE TABLE ADMIN.PHANCONG (
    MAGV NVARCHAR2(20),
    MAHP NVARCHAR2(20),
    HK NVARCHAR2(10),
    NAM NVARCHAR2(4),
    MACT NVARCHAR2(20),
    PRIMARY KEY (MAGV,MAHP, HK, NAM, MACT),
    FOREIGN KEY(MAGV) REFERENCES ADMIN.NHANSU(MANV),
    FOREIGN KEY (MAHP,HK,NAM,MACT) REFERENCES ADMIN.KHMO(MAHP,HK,NAM,MACT)
);
/
CREATE TABLE ADMIN.DANGKY (
    MASV NVARCHAR2(20),
    MAGV NVARCHAR2(20),
    MAHP NVARCHAR2(20),
    HK NVARCHAR2(10),
    NAM NVARCHAR2(4),
    MACT NVARCHAR2(20),
    DIEMTHI NUMBER(4,2),
    DIEMQT  NUMBER(4,2),
    DIEMCK NUMBER(4,2),
    DIEMTK  NUMBER(4,2),
    PRIMARY KEY (MASV, MAGV,MAHP, HK, NAM, MACT),
    FOREIGN KEY (MASV) REFERENCES ADMIN.SINHVIEN(MASV),
    FOREIGN KEY (MAGV,MAHP,HK,NAM,MACT) REFERENCES ADMIN.PHANCONG(MAGV,MAHP,HK,NAM,MACT)
);

--------------------------------------MÃ HÓA-------------------------------
CREATE OR REPLACE TRIGGER ADMIN.TRG_IUD_PHANCONG
BEFORE
    INSERT OR UPDATE OR DELETE ON ADMIN.PHANCONG
FOR EACH ROW
BEGIN
    -- Xử lý cập nhật
    IF UPDATING THEN
        BEGIN
            -- Cập nhật bảng DANGKY trước
            UPDATE ADMIN.DANGKY
            SET MAGV = :NEW.MAGV,
                MAHP = :NEW.MAHP,
                HK = :NEW.HK,
                NAM = :NEW.NAM,
                MACT = :NEW.MACT
            WHERE MAGV = :OLD.MAGV
              AND MAHP = :OLD.MAHP
              AND HK = :OLD.HK
              AND NAM = :OLD.NAM
              AND MACT = :OLD.MACT;
        EXCEPTION
            WHEN OTHERS THEN
                DBMS_OUTPUT.PUT_LINE('Lỗi khi cập nhật bảng DANGKY: ' || SQLERRM);
                RAISE_APPLICATION_ERROR(-20001, 'Lỗi khi cập nhật bảng DANGKY: ' || SQLERRM);
        END;
    -- Xử lý chèn (không cần thiết vì không ảnh hưởng đến bảng DANGKY)
    ELSIF INSERTING THEN
        NULL; -- Không có hành động
    -- Xử lý xóa
    ELSIF DELETING THEN
        BEGIN
            -- Xóa bảng DANGKY trước
            DELETE FROM ADMIN.DANGKY
            WHERE MAGV = :OLD.MAGV
              AND MAHP = :OLD.MAHP
              AND HK = :OLD.HK
              AND NAM = :OLD.NAM
              AND MACT = :OLD.MACT;
        EXCEPTION
            WHEN OTHERS THEN
                DBMS_OUTPUT.PUT_LINE('Lỗi khi xóa bảng DANGKY: ' || SQLERRM);
                RAISE_APPLICATION_ERROR(-20002, 'Lỗi khi xóa bảng DANGKY: ' || SQLERRM);
        END;
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Lỗi trong trigger TRG_IUD_PHANCONG: ' || SQLERRM);
        RAISE_APPLICATION_ERROR(-20003, 'Lỗi trong trigger TRG_IUD_PHANCONG: ' || SQLERRM);
END;
/
DROP TRIGGER ADMIN.TRG_U_KHMO;
CREATE OR REPLACE TRIGGER ADMIN.TRG_U_KHMO
BEFORE
    INSERT OR UPDATE ON ADMIN.KHMO
FOR EACH ROW
BEGIN
    -- Xử lý cập nhật
    IF UPDATING THEN
        BEGIN
            -- Cập nhật bảng DANGKY trước
            UPDATE ADMIN.PHANCONG
            SET MAHP = :NEW.MAHP,
                HK = :NEW.HK,
                NAM = :NEW.NAM,
                MACT = :NEW.MACT
            WHERE 
              MAHP = :OLD.MAHP
              AND HK = :OLD.HK
              AND NAM = :OLD.NAM
              AND MACT = :OLD.MACT;
        EXCEPTION
            WHEN OTHERS THEN
                DBMS_OUTPUT.PUT_LINE('Lỗi khi cập nhật bảng PHANCONG: ' || SQLERRM);
                RAISE_APPLICATION_ERROR(-20001, 'Lỗi khi cập nhật bảng PHANCONG: ' || SQLERRM);
        END;
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Lỗi trong trigger TRG_UD_KHMO: ' || SQLERRM);
        RAISE_APPLICATION_ERROR(-20003, 'Lỗi trong trigger TRG_UD_KHMO: ' || SQLERRM);
END;
/

DROP TRIGGER trg_encrypt_phucap;
CREATE OR REPLACE TRIGGER trg_encrypt_phucap
BEFORE INSERT OR UPDATE ON ADMIN.NHANSU
FOR EACH ROW
DECLARE
  input_key VARCHAR2(50);
  raw_key RAW(128);
  raw_iv RAW(16); -- Khởi tạo IV với kích thước 16 byte
  v_raw_phucap RAW(2000);
  v_encrypted_phucap RAW(2000);
BEGIN
  input_key := 'mysecretkey12345';
  -- Tạo IV ngẫu nhiên
  raw_iv := DBMS_CRYPTO.RANDOMBYTES(16);
  -- Khóa mã hóa
  raw_key := UTL_RAW.CAST_TO_RAW(CONVERT(input_key, 'AL32UTF8', 'US7ASCII'));
  -- Chuyển đổi giá trị PHUCAP thành RAW
  v_raw_phucap := UTL_RAW.CAST_TO_RAW(TO_CHAR(:NEW.PHUCAP));

  IF INSERTING THEN
    -- Mã hóa giá trị PHUCAP với IV
    v_encrypted_phucap := DBMS_CRYPTO.ENCRYPT(src => v_raw_phucap,
                                              typ => DBMS_CRYPTO.DES_CBC_PKCS5,
                                              key => raw_key,
                                              iv => raw_iv);
    -- Lưu IV và giá trị mã hóa trong PHUCAP (nối chúng lại)
    :NEW.PHUCAP := RAWTOHEX(raw_iv) || RAWTOHEX(v_encrypted_phucap);
  ELSIF UPDATING THEN
    IF :NEW.PHUCAP != :OLD.PHUCAP THEN
      -- Mã hóa giá trị PHUCAP với IV
      v_encrypted_phucap := DBMS_CRYPTO.ENCRYPT(src => v_raw_phucap,
                                                typ => DBMS_CRYPTO.DES_CBC_PKCS5,
                                                key => raw_key,
                                                iv => raw_iv);
      -- Lưu IV và giá trị mã hóa trong PHUCAP (nối chúng lại)
      :NEW.PHUCAP := RAWTOHEX(raw_iv) || RAWTOHEX(v_encrypted_phucap);
    END IF;
  END IF;
END;
/
CREATE OR REPLACE FUNCTION decrypt_phucap (p_encrypted_phucap VARCHAR2) RETURN VARCHAR2 IS
  input_key VARCHAR2(50);
  raw_key RAW(128);
  v_iv RAW(16);
  v_raw_encrypted RAW(2000);
  v_decrypted_phucap VARCHAR2(2000);
BEGIN
    input_key := 'mysecretkey12345';
  -- Khóa mã hóa, phải giống với khóa đã dùng để mã hóa
    raw_key := UTL_RAW.CAST_TO_RAW(CONVERT(input_key, 'AL32UTF8', 'US7ASCII'));

  -- Tách IV và giá trị mã hóa từ chuỗi HEX
  v_iv := HEXTORAW(SUBSTR(p_encrypted_phucap, 1, 32));
  v_raw_encrypted := HEXTORAW(SUBSTR(p_encrypted_phucap, 33));

  -- Giải mã giá trị PHUCAP với IV
  v_decrypted_phucap := UTL_RAW.CAST_TO_VARCHAR2(DBMS_CRYPTO.DECRYPT(src => v_raw_encrypted,
                                      typ => DBMS_CRYPTO.DES_CBC_PKCS5,
                                      key => raw_key,
                                      iv => v_iv));

  RETURN v_decrypted_phucap;
END;

/
drop view view_decrypted_nhansu;
CREATE OR REPLACE VIEW view_decrypted_nhansu AS
SELECT MANV,HOTEN,PHAI,NGSINH,decrypt_phucap(PHUCAP) AS PHUCAP,DT,VAITRO,MADV, COSO
FROM ADMIN.NHANSU;


drop view view_add_phancong;
CREATE OR REPLACE VIEW ADMIN.VIEW_ADD_PHANCONG AS
SELECT kh.HK, 
       kh.NAM, 
       kh.MACT, 
       hp.MAHP,
       hp.TENHP,
       hp.MADV
       -- Chỉ chọn các cột cần thiết từ bảng HOCPHAN, tránh trùng lặp cột
FROM ADMIN.HOCPHAN hp
JOIN ADMIN.KHMO kh ON hp.MAHP = kh.MAHP
LEFT JOIN ADMIN.PHANCONG pc ON kh.MAHP = pc.MAHP 
                           AND kh.HK = pc.HK 
                           AND kh.NAM = pc.NAM 
                           AND kh.MACT = pc.MACT
WHERE pc.MAGV IS NULL
  AND kh.HK = (CASE 
                 WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 9 AND 12 THEN '1'
                 WHEN EXTRACT(MONTH FROM SYSDATE) BETWEEN 1 AND 4 THEN '2'
                 ELSE '3'
               END)
  AND kh.NAM = TO_CHAR(SYSDATE, 'YYYY') AND hp.MADV = (SELECT MADV  FROM ADMIN.view_decrypted_nhansu  WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER'))
