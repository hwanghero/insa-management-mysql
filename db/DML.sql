use insa;
show tables;
desc user;
desc thrm_bas;

Select count(*) from user;
select * from user;
delete from user;

INSERT INTO user(id, pw, password_miss, joinday) VALUES (1234, 1234, 0, "new", "user");
update user set password_miss=0; -- 업데이트
update user set level="관리자"; -- 업데이트
update user set pw='1234', password_miss=1, joinday='2020-04-03', level='관리자' where id=1234;
alter table user add level varchar(10); -- 컬럼 추가
alter table user MODIFY COLUMN pw varchar(500); -- 컬럼 수정
ALTER TABLE user DROP PRIMARY KEY;   -- 기본키를 지워준다.
ALTER TABLE user ADD CONSTRAINT userid PRIMARY KEY (id);   -- PK를 생성한다.