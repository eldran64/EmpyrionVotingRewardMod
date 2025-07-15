# Empyrion Voting Reward Mod

**Ceci est un fork de [GitHub-TC/EmpyrionVotingRewardMod](https://github.com/GitHub-TC/EmpyrionVotingRewardMod).**

Droits d’auteur originaux © GitHub-TC et contributeurs  
Modifications © 2025 [El Dran/ Eldran64]

Ce projet est distribué sous licence [GNU GPL v3.0](LICENSE).

**Changelog du fork :**
- Ajout du support multilingue (FR/EN)

Voir [LICENSE](LICENSE) pour les détails.

## Installation
Your can direct load this mod with the EWA (Empyrion Web Access) MOD manager.<br/>
Without the EWA the mod works only within the EmpyrionModHost

## Config your rewards
After the installation and the start of the mod is here an example configuration which can be adapted.
[SaveGamePath]\\Mods\\VotingReward\\Configuration.json

Here also the API key must be deposited for the access to https://empyrion-servers.com

## Usage
After a vote on the page https://empyrion-servers.com the player can request his reward with the fractional vote
* "\\votereward" gives you a reward
* "\\votelottery" play in the lottery with your vote
* "\\voteforstat health" increase your m axhealth with you vote
* "\\voteforstat stamina" increase your max stamina with you vote
* "\\voteforstat food" increase your max food with you vote
* "\\voteforstat oxygen" increase your max oxygen with you vote

With the command "\\vote help" the player can retrieve the possible rewards and his number of votes.

Configuration parameters:
```
{0} = VotingApiServerKey
{1} = Spieler SteamID
{2} = Spielername
```

Configuration for top-games.net (PlayerName):
```
"ServerVotingHomepage": "https://top-games.net",
"GetUnclaimedVoteUrl" : "https://api.top-games.net/v1/votes/claim-username?server_token={0}&playername={2}",
"GetUnclaimedVoteMatch": ".*\"claimed\"\\s*:\\s*1\\s*,.*",
"ClaimedVoteUrl": "",
```

Configuration for top-games.net (SteamID) (does not seem to be working):
```
"ServerVotingHomepage": "https://top-games.net",
"GetUnclaimedVoteUrl" : "https://api.top-games.net/v1/votes/claim-steam?server_token={0}&steam_id={1}",
"GetUnclaimedVoteMatch": ".*\"claimed\"\\s*:\\s*1\\s*,.*",
"ClaimedVoteUrl": "",
```
