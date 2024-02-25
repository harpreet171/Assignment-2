using System;
using System.Collections.Generic;

namespace GemHuntersConsoleGame
{
    public class Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Cell
    {
        public string Occupant { get; set; }
    }

    public class Player
    {
        public string Name { get; }
        public Position Position { get; set; }
        public int GemCount { get; set; }

        public Player(string name, int x, int y)
        {
            Name = name;
            Position = new Position(x, y);
            GemCount = 0;
        }

        public void Move(char direction)
        {
            Position newPosition = Position.X == 0 && direction == 'U'
                ? new Position(5, 5)
                : Position == new Position(5, 5) && direction == 'D'
                    ? new Position(0, 0)
                    : Position == new Position(0, 0) && direction == 'D'
                        ? Position
                        : Position == new Position(5, 5) && direction == 'U'
                            ? Position
                            : MoveInternal(direction);

            if (newPosition != null)
            {
                Position = newPosition;
                if (Cell.Occupant == "G")
                {
                    GemCount++;
                    Cell.Occupant = "-";
                }
            }
        }

        private Position MoveInternal(char direction)
        {
            int x = Position.X;
            int y = Position.Y;

            switch (direction)
            {
                case 'U':
                    y--;
                    break;
                case 'D':
                    y++;
                    break;
                case 'L':
                    x--;
                    break;
                case 'R':
                    x++;
                    break;
                default:
                    return Position;
            }

            return new Position(x, y);
        }
    }

    public class Board
    {
        public Cell[,] Grid { get; }

        public Board(int size)
        {
            Grid = new Cell[size, size];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            Random random = new Random();
            int size = Grid.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (random.NextDouble() < 0.2)
                        Grid[i, j] = new Cell { Occupant = "G" };
                    else if (random.NextDouble() < 0.1)
                        Grid[i, j] = new Cell { Occupant = "O" };
                    else
                        Grid[i, j] = new Cell { Occupant = "-" };
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Console.Write(Grid[i, j].Occupant);
                }
                Console.WriteLine();
            }
        }

        public bool IsValidMove(Player player, char direction)
        {
            Position newPosition = player.Position.X == 0 && direction == 'U'
                ? new Position(5, 5)
                : Position == new Position(5, 5) && direction == 'D'
                    ? new Position(0, 0)
                    : Position == new Position(0, 0) && direction == 'D'
                        ? Position
                        : Position == new Position(5, 5) && direction == 'U'
                            ? Position
