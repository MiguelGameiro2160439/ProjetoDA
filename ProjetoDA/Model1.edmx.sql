
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2017 11:22:41
-- Generated from EDMX file: C:\Users\migue\Documents\ESTG\Desenvolvimento de Aplicações\ProjetoDA\ProjetoDA\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ArcMageBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CardSet'
CREATE TABLE [dbo].[CardSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Faction] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Cost] nvarchar(max)  NOT NULL,
    [Loyalty] int  NOT NULL,
    [RuleText] nvarchar(max)  NOT NULL,
    [Attack] int  NOT NULL,
    [Defense] int  NOT NULL
);
GO

-- Creating table 'TournamentSet'
CREATE TABLE [dbo].[TournamentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GameSet'
CREATE TABLE [dbo].[GameSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RefereeId] int  NULL,
    [DeckOneId] int  NULL,
    [DeckTwoId] int  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Number] int  NOT NULL
);
GO

-- Creating table 'DeckSet'
CREATE TABLE [dbo].[DeckSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TeamSet'
CREATE TABLE [dbo].[TeamSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PlayerSet'
CREATE TABLE [dbo].[PlayerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Nickname] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet_Referee'
CREATE TABLE [dbo].[UserSet_Referee] (
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'GameSet_TeamGame'
CREATE TABLE [dbo].[GameSet_TeamGame] (
    [TeamTournamentId] int  NOT NULL,
    [TeamOneId] int  NULL,
    [TeamTwoId] int  NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'TournamentSet_TeamTournament'
CREATE TABLE [dbo].[TournamentSet_TeamTournament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'TournamentSet_StandardTournament'
CREATE TABLE [dbo].[TournamentSet_StandardTournament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'GameSet_StandardGame'
CREATE TABLE [dbo].[GameSet_StandardGame] (
    [PlayerOneId] int  NULL,
    [PlayerTwoId] int  NULL,
    [StandardTournamentId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UserSet_Administrator'
CREATE TABLE [dbo].[UserSet_Administrator] (
    [Email] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'DeckCard'
CREATE TABLE [dbo].[DeckCard] (
    [Decks_Id] int  NOT NULL,
    [Cards_Id] int  NOT NULL
);
GO

-- Creating table 'TeamTeamTournament'
CREATE TABLE [dbo].[TeamTeamTournament] (
    [Teams_Id] int  NOT NULL,
    [Tournaments_Id] int  NOT NULL
);
GO

-- Creating table 'TeamPlayer'
CREATE TABLE [dbo].[TeamPlayer] (
    [Teams_Id] int  NOT NULL,
    [Players_Id] int  NOT NULL
);
GO

-- Creating table 'PlayerStandard_Tournament'
CREATE TABLE [dbo].[PlayerStandard_Tournament] (
    [Tournaments_Id] int  NOT NULL,
    [Players_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CardSet'
ALTER TABLE [dbo].[CardSet]
ADD CONSTRAINT [PK_CardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TournamentSet'
ALTER TABLE [dbo].[TournamentSet]
ADD CONSTRAINT [PK_TournamentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [PK_GameSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeckSet'
ALTER TABLE [dbo].[DeckSet]
ADD CONSTRAINT [PK_DeckSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeamSet'
ALTER TABLE [dbo].[TeamSet]
ADD CONSTRAINT [PK_TeamSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PlayerSet'
ALTER TABLE [dbo].[PlayerSet]
ADD CONSTRAINT [PK_PlayerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet_Referee'
ALTER TABLE [dbo].[UserSet_Referee]
ADD CONSTRAINT [PK_UserSet_Referee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [PK_GameSet_TeamGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TournamentSet_TeamTournament'
ALTER TABLE [dbo].[TournamentSet_TeamTournament]
ADD CONSTRAINT [PK_TournamentSet_TeamTournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TournamentSet_StandardTournament'
ALTER TABLE [dbo].[TournamentSet_StandardTournament]
ADD CONSTRAINT [PK_TournamentSet_StandardTournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GameSet_StandardGame'
ALTER TABLE [dbo].[GameSet_StandardGame]
ADD CONSTRAINT [PK_GameSet_StandardGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet_Administrator'
ALTER TABLE [dbo].[UserSet_Administrator]
ADD CONSTRAINT [PK_UserSet_Administrator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Decks_Id], [Cards_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [PK_DeckCard]
    PRIMARY KEY CLUSTERED ([Decks_Id], [Cards_Id] ASC);
GO

-- Creating primary key on [Teams_Id], [Tournaments_Id] in table 'TeamTeamTournament'
ALTER TABLE [dbo].[TeamTeamTournament]
ADD CONSTRAINT [PK_TeamTeamTournament]
    PRIMARY KEY CLUSTERED ([Teams_Id], [Tournaments_Id] ASC);
GO

-- Creating primary key on [Teams_Id], [Players_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [PK_TeamPlayer]
    PRIMARY KEY CLUSTERED ([Teams_Id], [Players_Id] ASC);
GO

-- Creating primary key on [Tournaments_Id], [Players_Id] in table 'PlayerStandard_Tournament'
ALTER TABLE [dbo].[PlayerStandard_Tournament]
ADD CONSTRAINT [PK_PlayerStandard_Tournament]
    PRIMARY KEY CLUSTERED ([Tournaments_Id], [Players_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RefereeId] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [FK_RefereeGame]
    FOREIGN KEY ([RefereeId])
    REFERENCES [dbo].[UserSet_Referee]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RefereeGame'
CREATE INDEX [IX_FK_RefereeGame]
ON [dbo].[GameSet]
    ([RefereeId]);
GO

-- Creating foreign key on [DeckOneId] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [FK_GameDeck]
    FOREIGN KEY ([DeckOneId])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameDeck'
CREATE INDEX [IX_FK_GameDeck]
ON [dbo].[GameSet]
    ([DeckOneId]);
GO

-- Creating foreign key on [DeckTwoId] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [FK_GameDeck2]
    FOREIGN KEY ([DeckTwoId])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameDeck2'
CREATE INDEX [IX_FK_GameDeck2]
ON [dbo].[GameSet]
    ([DeckTwoId]);
GO

-- Creating foreign key on [Decks_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [FK_DeckCard_Deck]
    FOREIGN KEY ([Decks_Id])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Cards_Id] in table 'DeckCard'
ALTER TABLE [dbo].[DeckCard]
ADD CONSTRAINT [FK_DeckCard_Card]
    FOREIGN KEY ([Cards_Id])
    REFERENCES [dbo].[CardSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckCard_Card'
CREATE INDEX [IX_FK_DeckCard_Card]
ON [dbo].[DeckCard]
    ([Cards_Id]);
GO

-- Creating foreign key on [TeamTournamentId] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamGameTeamTournament]
    FOREIGN KEY ([TeamTournamentId])
    REFERENCES [dbo].[TournamentSet_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamGameTeamTournament'
CREATE INDEX [IX_FK_TeamGameTeamTournament]
ON [dbo].[GameSet_TeamGame]
    ([TeamTournamentId]);
GO

-- Creating foreign key on [TeamOneId] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamGame_Team1]
    FOREIGN KEY ([TeamOneId])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamGame_Team1'
CREATE INDEX [IX_FK_TeamGame_Team1]
ON [dbo].[GameSet_TeamGame]
    ([TeamOneId]);
GO

-- Creating foreign key on [TeamTwoId] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamGame_Team2]
    FOREIGN KEY ([TeamTwoId])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamGame_Team2'
CREATE INDEX [IX_FK_TeamGame_Team2]
ON [dbo].[GameSet_TeamGame]
    ([TeamTwoId]);
GO

-- Creating foreign key on [Teams_Id] in table 'TeamTeamTournament'
ALTER TABLE [dbo].[TeamTeamTournament]
ADD CONSTRAINT [FK_TeamTeamTournament_Team]
    FOREIGN KEY ([Teams_Id])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tournaments_Id] in table 'TeamTeamTournament'
ALTER TABLE [dbo].[TeamTeamTournament]
ADD CONSTRAINT [FK_TeamTeamTournament_TeamTournament]
    FOREIGN KEY ([Tournaments_Id])
    REFERENCES [dbo].[TournamentSet_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTeamTournament_TeamTournament'
CREATE INDEX [IX_FK_TeamTeamTournament_TeamTournament]
ON [dbo].[TeamTeamTournament]
    ([Tournaments_Id]);
GO

-- Creating foreign key on [Teams_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [FK_TeamPlayer_Team]
    FOREIGN KEY ([Teams_Id])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Players_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [FK_TeamPlayer_Player]
    FOREIGN KEY ([Players_Id])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamPlayer_Player'
CREATE INDEX [IX_FK_TeamPlayer_Player]
ON [dbo].[TeamPlayer]
    ([Players_Id]);
GO

-- Creating foreign key on [Tournaments_Id] in table 'PlayerStandard_Tournament'
ALTER TABLE [dbo].[PlayerStandard_Tournament]
ADD CONSTRAINT [FK_PlayerStandard_Tournament_Player]
    FOREIGN KEY ([Tournaments_Id])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Players_Id] in table 'PlayerStandard_Tournament'
ALTER TABLE [dbo].[PlayerStandard_Tournament]
ADD CONSTRAINT [FK_PlayerStandard_Tournament_StandardTournament]
    FOREIGN KEY ([Players_Id])
    REFERENCES [dbo].[TournamentSet_StandardTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandard_Tournament_StandardTournament'
CREATE INDEX [IX_FK_PlayerStandard_Tournament_StandardTournament]
ON [dbo].[PlayerStandard_Tournament]
    ([Players_Id]);
GO

-- Creating foreign key on [PlayerOneId] in table 'GameSet_StandardGame'
ALTER TABLE [dbo].[GameSet_StandardGame]
ADD CONSTRAINT [FK_StandardGamePlayer]
    FOREIGN KEY ([PlayerOneId])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StandardGamePlayer'
CREATE INDEX [IX_FK_StandardGamePlayer]
ON [dbo].[GameSet_StandardGame]
    ([PlayerOneId]);
GO

-- Creating foreign key on [PlayerTwoId] in table 'GameSet_StandardGame'
ALTER TABLE [dbo].[GameSet_StandardGame]
ADD CONSTRAINT [FK_StandardGamePlayer1]
    FOREIGN KEY ([PlayerTwoId])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StandardGamePlayer1'
CREATE INDEX [IX_FK_StandardGamePlayer1]
ON [dbo].[GameSet_StandardGame]
    ([PlayerTwoId]);
GO

-- Creating foreign key on [StandardTournamentId] in table 'GameSet_StandardGame'
ALTER TABLE [dbo].[GameSet_StandardGame]
ADD CONSTRAINT [FK_StandardGameStandardTournament]
    FOREIGN KEY ([StandardTournamentId])
    REFERENCES [dbo].[TournamentSet_StandardTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StandardGameStandardTournament'
CREATE INDEX [IX_FK_StandardGameStandardTournament]
ON [dbo].[GameSet_StandardGame]
    ([StandardTournamentId]);
GO

-- Creating foreign key on [Id] in table 'UserSet_Referee'
ALTER TABLE [dbo].[UserSet_Referee]
ADD CONSTRAINT [FK_Referee_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[GameSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TournamentSet_TeamTournament'
ALTER TABLE [dbo].[TournamentSet_TeamTournament]
ADD CONSTRAINT [FK_TeamTournament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TournamentSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TournamentSet_StandardTournament'
ALTER TABLE [dbo].[TournamentSet_StandardTournament]
ADD CONSTRAINT [FK_StandardTournament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TournamentSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'GameSet_StandardGame'
ALTER TABLE [dbo].[GameSet_StandardGame]
ADD CONSTRAINT [FK_StandardGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[GameSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UserSet_Administrator'
ALTER TABLE [dbo].[UserSet_Administrator]
ADD CONSTRAINT [FK_Administrator_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------