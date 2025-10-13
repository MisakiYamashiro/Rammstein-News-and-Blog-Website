create database RammsteinBlogWebAppDB
go
use RammsteinBlogWebAppDB
go
create table Types 
(
	TypeID int primary key identity(1,1),
	Name nvarchar(40),
	IsActive bit,
)
GO
create table Categories
(
	CategoryID int primary key identity(1,1),
	Name nvarchar(40),
	IsActive bit,
)
go
create table Roles
(
	RoleID int primary key identity(1,1),
	Name nvarchar(60),
)
go
insert into Roles(Name) values('User')
insert into Roles(Name) values('Admin')
insert into Roles(Name) values('Author')
go
create table Users
(
	UserID int primary key identity(1,1),
	RoleID int,
	Name nvarchar(130),
	Username nvarchar(150),
	Lastname nvarchar(120),
	Email nvarchar(70),
	Password nvarchar(40),
	DateOfJoin date,
	constraint fk_UserRole foreign key(RoleID)
	references Roles(RoleID)
)
go
insert into Users(RoleID, Name, Username, Lastname, Email, Password, DateOfJoin)
values(2,'Efe','misakidev','Palaz','palazefe8796@gmail.com','VenaturaMelatonin1234','2025/10/5')
go
create table Articles
(
	ArticleID int primary key identity(1,1),
	TypeID int,
	CategoryID int,
	AuthorID int,
	Title nvarchar(150),
	Content ntext,
	Date date,
	UpdateDate date,
	Upvote int,
	Downvote int,
	Views int,
	Allow_Comments bit,
	constraint fk_ArticleType foreign key(TypeID)
	references Types(TypeID),
	constraint fk_ArticleCategory foreign key(CategoryID)
	references Categories(CategoryID),
	constraint fk_ArticleAuthor foreign key(AuthorID)
	references Users(UserID)

)
go
create table Comments
(
	CommentID int primary key identity(1,1),
	UserID int,
	Content ntext,
	Date date,
	Upvote int,
	Downvote int,
	constraint fk_CommentUser foreign key(UserID)
	references Users(UserID)
)
go
create table Soft_Deleted_Comments
(
ID int primary key identity(1,1),
CommentID int,
Reason nvarchar(100),
constraint fk_CommentSoft foreign key(CommentID) references Comments(CommentID)
)
go
create table Banned_Users
(
ID int primary key identity(1,1),
UserID int,
constraint fk_BannedUser foreign key(UserID) references Users(UserID)
)
go
create table Comments_Reply 
(
main_commentID int,
reply_commentID int,
constraint pk_commentsreply primary key(main_commentID, reply_commentID),
constraint fk_maincomment foreign key(main_commentID) references Comments(CommentID),
constraint fk_replycomment foreign key(reply_commentID) references Comments(CommentID)
)