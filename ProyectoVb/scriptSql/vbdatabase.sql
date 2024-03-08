create database vbdatabase;
use vbdatabase;
drop table if exists recovery;
drop table  if exists users;
drop table  if exists roles;
drop table  if exists roles;
create table roles(
	id_rol int auto_increment,
    description varchar(64),
    primary key(id_rol)
);

create table users(
	id_user int auto_increment,
    name varchar(64),
    password varchar(256),
    email varchar(256),
    status enum('Activated','Deactivated') default ('Activated'),
    last_login datetime default now(),
    id_rol int default (3),
    primary key(id_user),
    foreign key(id_rol) references roles(id_rol)
);

create table recovery(
	id_recovery int auto_increment,
	id_user int,
    new_password datetime default now(),
    primary key(id_recovery),
	foreign key(id_user) references users(id_user)
);
insert into roles(description) values
("Owner"),("Admin"),("User");
insert into users(name, password,id_rol)
values("Owner","1234",1);

/* Explicación:
Procedimiento que añade un nuevo registro en la tabla 'users'
*/

drop procedure if exists addUser; 

create procedure addUser(in _name varchar(255),in _pass varchar(255),out _res int)
begin
	declare val int default 0;
    set _res= -99;
	select count(*) into val from users where name=_name;
    if val<1 then
		insert into users (name,password)
		values(_name,_pass);
        set _res =1;
    else
    set _res =-1; 
    end if;
end ;
/* Explicación:
Procedimiento que devuelve el valor de 'users.id_user' si lo encuentra por 
los valores dados a 'users.name' y 'users.password'
OJO los valores que guarda 'users.password' estan hasheados
*/
drop procedure if exists findUser; 

create procedure findUser(in _name varchar(255),in _pass varchar(255),out _res int)
begin
	declare val int default 0;
    set _res= -99;
	select id_user into val from users where name=_name and password=_pass;
    if val<1 then
		set _res =-1;
    else
		set _res=val;
	end if;
end;

drop procedure if exists alterStatus; 
create procedure alterStatus(in _id_user int,out _res int)
begin
	declare val int default 0;
    declare st enum('Activated','Deactivated');
    set _res= -99;
	select id_user into val from users where id_user=_id_user;
    if val<1 then
		set _res =-1;
    else
		select datediff(now(),last_login) into val from users where id_user=_id_user;
        if val >3 then
			select status into st from users where id_user=_id_user;
			if st =('Activated') then
				set st=('Deactivated');
			else
				set st=('Activated');
			end if;
			update users set status = st where id_user=_id_user;
		end if;
	end if;
end ;
drop procedure if exists upgradeUser; 
create procedure upgradeUser(in _id_admin int,in _id_user int,out _res int)
begin
	declare val int default 0;
	declare val2 int default 0;
    set _res= -99;
	select id_user into val from users where id_user=_id_user;
    if val<1 then
		set _res =-2;
    else
        select id_user into val from users where id_user=_id_admin;
        if val<1 then
			set _res =-3;
		else
			select id_rol into val from users where id_user=_id_admin;
			select id_rol into val2 from users where id_user=_id_user;
            if val2>val then
				if val2>2 then
					set val2=val2-1;
					update users set id_rol =val2 where id_user=_id_user;
                    set _res=1;
                end if;
            else
				set _res =-4;
            end if;
		end if;
	end if;
end;
drop procedure if exists downgradeUser; 
create procedure downgradeUser(in _id_admin int,in _id_user int,out _res int)
begin
	declare val int default 0;
	declare val2 int default 0;
    set _res= -99;
	select id_user into val from users where id_user=_id_user;
    if val<1 then
		set _res =-2;
    else
        select id_user into val from users where id_user=_id_admin;
        if val<1 then
			set _res =-3;
		else
			select id_rol into val from users where id_user=_id_admin;
			select id_rol into val2 from users where id_user=_id_user;
            if val2>val then
				if val2<3 then
					set val2=val2+1;
					update users set id_rol =val2 where id_user=_id_user;
                end if;
            else
				set _res =-4;
            end if;
		end if;
	end if;
end;
drop procedure if exists changeOwnership; 

create procedure changeOwnership(in _id_owner int,in _id_user int,out _res int)
begin
	declare val int default 0;
    set _res= -99;
	select count(id_user) into val from users where id_user=_id_user and id_rol =2;
    if val<1 then
		set _res =-1;
    else
		select count(id_user) into val from users where id_user=_id_owner and id_rol =1;
		if val<1 then
			set _res =-2;
		else
			update users set id_rol = 1 where id_user=_id_user;
			update users set id_rol = 2 where id_user=_id_owner;
        end if;
	end if;
end;

drop procedure if exists addRecovery; 

create procedure addRecovery(in _id_user int,out _res int)
begin
	declare val int default 0;
    set _res= -99;
	select count(*) into val from users where id_user=_id_user;
    if val<1 then
		set _res =-1; 
    else
		delete from recovery where id_user=_id_user;
		insert into recovery(id_user)
		values(_id_user);
        set _res =1;
    end if;
end;