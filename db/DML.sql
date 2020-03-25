use insa;
show tables;
desc user;

select * from user;
delete from user;

update user set password_miss=0; -- 업데이트
alter table user add level varchar(10); -- 컬럼 추가
alter table user MODIFY COLUMN joinday varchar(10); -- 컬럼 수정
ALTER TABLE user DROP PRIMARY KEY;   -- 기본키를 지워준다.
ALTER TABLE user ADD CONSTRAINT userid PRIMARY KEY (id);   -- PK를 생성한다.