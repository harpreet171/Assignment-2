# Assignment-2

https://youtu.be/9tNtzvmebC4

Site category: This category represents locations on the game board. It consists of two characters, X and Y, which represent the location of the job.

Player: This group represents the players in the game. It has three properties: Name (the player's name), Location (the player's current position on the board), and GemCount (the number of gems the player has typed). The move changes the player's position relative to the input direction (U, D, L or R).

Cell Category: This class represents the cells on the game board. It has the character Occupant (P1, P2, G, O or - stands for empty), which represents the contents of the cell.

Class: This class represents the board game. It features Grid, which is a two-dimensional array of cell objects. The InitializeBoard method sets up the board with players, diamonds, and problems. The visual method prints the current status of the card to the console. The IsValidMove method checks whether the move is valid (within a boundary and not blocked by an obstacle). The CollectGem method checks for gems at the player's new location and updates the player's GemCount.

Game Category: This category represents the game itself. It has five objects: Board (game board), Player1 and Player2 (both players), CurrentTurn (player's turn), and TotalTurns (number of passes). The start starts the game, indicating that the board and players have changed. The SwitchTurn method switches between Player1 and Player2. The IsGameOver method checks whether the game has reached its end (30 rounds). The AnnaWinner method determines and announces the winner based on the player's GemCount.

Service Group: This group contains the main methods that create new Game objects and start the game.

In the main method, start the game by creating a new Game object and call the start method. The game continues until IsGameOver returns true; At this point the AnnounceWinner method is called to determine and announce the winner.
