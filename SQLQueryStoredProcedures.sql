use [Tournaments]
go

--1
--create proc [dbo].[spMatchupEntries_GetByMatchup]
--@matchupID int
--as
--begin
--	set nocount on;

--	select *
--	from [dbo].[MatchupEntries]
--	where [dbo].[MatchupEntries].[MatchupID] = @matchupID;
--end

--2
--create proc [dbo].[spMatchupEntries_Insert]
--	@matchupID int,
--	@parentMatchupID int,
--	@teamCompetingID int,
--	@Id int = 0 output
--as
--begin
--	set nocount on;

--	insert into [dbo].[MatchupEntries] (MatchupID, ParentMatchupID, TeamCompetingID)
--	values
--	(@matchupID, @parentMatchupID, @teamCompetingID);

--	select @Id = SCOPE_IDENTITY();
--end

--3
--create proc [dbo].[spMatchupEntries_Update]
--	@Id int,
--	@teamCompetingId int,
--	@score int
--as
--begin
--	set nocount on;

--	update [dbo].[MatchupEntries]
--	set TeamCompetingID = @teamCompetingId,
--		Score = @score

--	where id = @Id;
--end


--4
--CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
--	@TournamentId int
--AS
--BEGIN 

--	SET NOCOUNT ON;

--	SELECT		[Matchups].[Id], 
--				[Matchups].[TournamentId], 
--				[Matchups].[WinnerId], 
--				[Matchups].[MatchupRound]
--	FROM		[dbo].[Matchups]
--	WHERE		Matchups.TournamentId = @TournamentId
--	ORDER BY	Matchups.MatchupRound;

--END

--5
--CREATE PROCEDURE [dbo].[spMatchups_Insert]
--	@TournamentId int,
--	@MatchupRound int,
--	@Id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[Matchups] (TournamentId, MatchupRound)
--	VALUES(@TournamentId, @MatchupRound);

--	SELECT @Id = SCOPE_IDENTITY();

--END


--6
--CREATE PROCEDURE [dbo].[spMatchups_Update]
--	@Id int,
--	@WinnerId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	UPDATE [dbo].[Matchups]
--	SET WinnerId = @WinnerId
--	WHERE id = @id;

--END

--7
--CREATE PROCEDURE [dbo].[spPeople_GetAll]
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT	[People].[Id], 
--			[People].[FirstName], 
--			[People].[LastName], 
--			[People].[EmailAddress], 
--			[People].[CellphoneNumber]
--	FROM	[dbo].[People];
--END


--8
--CREATE PROCEDURE [dbo].[spPeople_Insert]
--	@FirstName nvarchar(100),
--	@LastName nvarchar(100),
--	@EmailAddress nvarchar(100),
--	@CellphoneNumber nvarchar(20),
--	@Id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[People] (FirstName, LastName, EmailAddress, CellphoneNumber)
--	VALUES (@FirstName, @LastName, @EmailAddress, @CellphoneNumber);

--	SELECT @Id = SCOPE_IDENTITY();
--END


--9
--CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
--	@TournamentId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT		[Prizes].[Id], 
--				[Prizes].[PlaceNumber], 
--				[Prizes].[PlaceName], 
--				[Prizes].[PrizeAmount], 
--				[Prizes].[PrizePercentage]
--	FROM		[dbo].[Prizes]
--	INNER JOIN	[dbo].[TournamentPrizes]
--	ON			TournamentPrizes.PrizeId = Prizes.Id
--	WHERE		TournamentPrizes.TournamentId = @TournamentId;

--END

--10
--CREATE PROCEDURE [dbo].[spPrizes_Insert]
--	@PlaceNumber int, 
--	@PlaceName nvarchar(50), 
--	@PrizeAmount money, 
--	@PrizePercentage float,
--	@Id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[Prizes] (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
--	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

--	SELECT @Id = SCOPE_IDENTITY();

--END


--11
--CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
--	@TeamId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT		[People].[Id], 
--				[People].[FirstName], 
--				[People].[LastName], 
--				[People].[EmailAddress], 
--				[People].[CellphoneNumber]
--	FROM		[dbo].[TeamMembers]
--	INNER JOIN	[dbo].[People]
--	ON			[People].[Id] = [TeamMembers].[PersonId]
--	WHERE		[TeamMembers].[TeamId] = @TeamId;

--END

--12
--CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
--	@TeamId int,
--	@PersonId int,
--	@id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[TeamMembers] (TeamId, PersonId)
--	VALUES (@TeamId, @PersonId)

--	SELECT @Id = SCOPE_IDENTITY();
--END
--GO

--13
--CREATE PROCEDURE [dbo].[spTeam_getByTournament]
--	@TournamentId int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT		[Teams].[Id], 
--				[Teams].[TeamName]
--	FROM		[dbo].[Teams]
--	INNER JOIN	[dbo].[TournamentEntries]
--	ON			TournamentEntries.TeamId = Teams.Id
--	WHERE		[TournamentEntries].[TournamentId] = @TournamentId;

--END

--14
--CREATE PROCEDURE [dbo].[spTeams_GetAll]
--AS
--BEGIN
--	SET NOCOUNT ON;

--	SELECT	[Teams].[Id], 
--			[Teams].[TeamName]
--	FROM	[dbo].[Teams];

--END


--15
--CREATE PROCEDURE [dbo].[spTeams_Insert]
--	@TeamName nvarchar(100),
--	@Id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[Teams] (TeamName)
--	VALUES (@TeamName)

--	SELECT @Id = SCOPE_IDENTITY();
--END
--GO

--16
--CREATE PROCEDURE [dbo].[spTournamentEntries_Insert]
--	@TournamentId int,
--	@TeamId int,
--	@Id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[TournamentEntries] (TournamentId, TeamId)
--	VALUES (@TournamentId, @TeamId)

--	SELECT @Id = SCOPE_IDENTITY();

--END

--17
--CREATE PROCEDURE [dbo].[spTournamentPrizes_Insert]
--	@TournamentId int,
--	@PrizeId int,
--	@Id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[TournamentPrizes] (TournamentId, PrizeId)
--	VALUES (@TournamentId, @PrizeId);

--	SELECT @Id = SCOPE_IDENTITY();
--END

--18
--CREATE PROCEDURE [dbo].[spTournaments_Complete]
--	@Id int
--AS
--BEGIN
--	SET NOCOUNT ON;

--	UPDATE [dbo].[Tournaments]
--	SET Active = 0
--	WHERE Id = @Id;

--END

--19
--CREATE PROCEDURE [dbo].[spTournaments_GetAll]
--AS
--BEGIN

--	SET NOCOUNT ON;
	
--	SELECT	Tournaments.Id, 
--			Tournaments.TournamentName, 
--			Tournaments.EntryFee, 
--			Tournaments.Active
--	FROM	[dbo].[Tournaments]
--	WHERE	Active = 1;

--END

--20
--CREATE PROCEDURE [dbo].[spTournaments_Insert]
--	@TournamentName nvarchar(200),
--	@EntryFee money,
--	@id int = 0 output
--AS
--BEGIN
--	SET NOCOUNT ON;

--	INSERT INTO [dbo].[Tournaments] (TournamentName, EntryFee, Active)
--	VALUES(@TournamentName, @EntryFee, 1);

--	SELECT @Id = SCOPE_IDENTITY();
--END
--GO