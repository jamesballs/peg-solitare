using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarblePuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //List<List<int[]>> moves = new List<List<int[]>>();
            List<int[][]> boards = new List<int[][]>();

            boards.Add(new int[1][]);

            int mainCounter = 1;

            while (true)
            {
                int[][] currentBoard = new int[][] { new int[] { 0, 0, 2, 2, 2, 0, 0 }, new int[] { 0, 0, 2, 1, 2, 0, 0 }, new int[] { 2, 2, 2, 1, 2, 2, 2 }, new int[] { 2, 2, 2, 2, 2, 2, 2 }, new int[] { 2, 2, 2, 2, 2, 2, 2 }, new int[] { 0, 0, 2, 2, 2, 0, 0 }, new int[] { 0, 0, 2, 2, 2, 0, 0 } };

                int counter = 0;

                List<int[]> currentMove = new List<int[]>();

                while (counter != 1000)
                {
                    int moveNum = 0;
                    int rowNum = 0;
                    int possibleMoves = 0;

                    

                    foreach (int[] row in currentBoard)
                    {
                        int colNum = 0;

                        foreach (int col in row)
                        {
                            if ((rowNum < 5) && (currentBoard[rowNum + 1][colNum] == 2) && (currentBoard[rowNum + 2][colNum] == 1))
                            {
                                possibleMoves++;
                            }
                            else if ((rowNum > 1) && (currentBoard[rowNum - 1][colNum] == 2) && (currentBoard[rowNum - 2][colNum] == 1))
                            {
                                possibleMoves++;
                            }
                            else if ((colNum < 5) && (currentBoard[rowNum][colNum + 1] == 2) && (currentBoard[rowNum][colNum + 2] == 1))
                            {
                                possibleMoves++;
                            }
                            else if ((colNum > 1) && (currentBoard[rowNum][colNum - 1] == 2) && (currentBoard[rowNum][colNum - 2] == 1))
                            {
                                possibleMoves++;
                            }

                            colNum++;
                        }

                        rowNum++;
                    }

                    //Console.WriteLine(possibleMoves);

                    rowNum = 0;

                    foreach (int[] row in currentBoard)
                    {
                        int colNum = 0;

                        foreach (int col in row)
                        {
                            if (col == 2)
                            {
                                if ((rowNum < 5) && (currentBoard[rowNum + 1][colNum] == 2) && (currentBoard[rowNum + 2][colNum] == 1))
                                {
                                    int[] coord = new int[] { rowNum, colNum, 2 };

                                    //Boolean doMove = true;

                                    //foreach (List<int[]> move in moves)
                                    //{
                                    //    if (move[moveNum].SequenceEqual(coord))
                                    //    {
                                    //        doMove = false;
                                    //    }
                                    //}

                                    var randomNum = rnd.NextDouble();

                                    if (randomNum <= 1.0/possibleMoves)
                                    {
                                        currentBoard[rowNum][colNum] = 1;
                                        currentBoard[rowNum + 1][colNum] = 1;
                                        currentBoard[rowNum + 2][colNum] = 2;
                                        currentMove.Add(coord);
                                    }
                                }
                                else if ((rowNum > 1) && (currentBoard[rowNum - 1][colNum] == 2) && (currentBoard[rowNum - 2][colNum] == 1))
                                {
                                    int[] coord = new int[] { rowNum, colNum, 0 };

                                    //Boolean doMove = true;

                                    //foreach (List<int[]> move in moves)
                                    //{
                                    //    if (move[moveNum].SequenceEqual(coord))
                                    //    {
                                    //        doMove = false;
                                    //    }
                                    //}

                                    var randomNum = rnd.NextDouble();

                                    if (randomNum <= 1.0 / possibleMoves)
                                    {
                                        currentBoard[rowNum][colNum] = 1;
                                        currentBoard[rowNum - 1][colNum] = 1;
                                        currentBoard[rowNum - 2][colNum] = 2;
                                        currentMove.Add(coord);
                                    }
                                }
                                else if ((colNum < 5) && (currentBoard[rowNum][colNum + 1] == 2) && (currentBoard[rowNum][colNum + 2] == 1))
                                {
                                    int[] coord = new int[] { rowNum, colNum, 1 };

                                    //Boolean doMove = true;

                                    //foreach (List<int[]> move in moves)
                                    //{
                                    //    if (move[moveNum].SequenceEqual(coord))
                                    //    {
                                    //        doMove = false;
                                    //    }
                                    //}

                                    var randomNum = rnd.NextDouble();

                                    if (randomNum <= 1.0 / possibleMoves)
                                    {
                                        currentBoard[rowNum][colNum] = 1;
                                        currentBoard[rowNum][colNum + 1] = 1;
                                        currentBoard[rowNum][colNum + 2] = 2;
                                        currentMove.Add(coord);
                                    }
                                }
                                else if ((colNum > 1) && (currentBoard[rowNum][colNum - 1] == 2) && (currentBoard[rowNum][colNum - 2] == 1))
                                {
                                    int[] coord = new int[] { rowNum, colNum, 3 };

                                    //Boolean doMove = true;

                                    //foreach (List<int[]> move in moves)
                                    //{
                                    //    if (move[moveNum].SequenceEqual(coord))
                                    //    {
                                    //        doMove = false;
                                    //    }
                                    //}

                                    var randomNum = rnd.NextDouble();

                                    if (randomNum <= 1.0 / possibleMoves)
                                    {
                                        currentBoard[rowNum][colNum] = 1;
                                        currentBoard[rowNum][colNum - 1] = 1;
                                        currentBoard[rowNum][colNum - 2] = 2;
                                        currentMove.Add(coord);
                                    }
                                }
                            }

                            colNum++;
                        }

                        rowNum++;
                    }

                    counter++;
                    moveNum++;
                }

                //if the count of the move is zero then a certain option must always be chosen.
                //if (currentMove.Count == 0)
                //{

                //}

                //moves.Add(currentMove);

                

                int ballCount = 0;

                foreach (int[] row in currentBoard)
                {
                    foreach (int col in row)
                    {
                        if (col == 2)
                        {
                            ballCount++;
                        }
                    }
                }

                //Console.WriteLine(ballCount);
                if (ballCount < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Low ball count found!!");

                    Console.WriteLine("Press v and enter to view this solution.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "v")
                    {
                        foreach (int[] row in currentBoard)
                        {
                            foreach (int col in row)
                            {
                                if (col == 0)
                                {
                                    Console.Write("  ");
                                }
                                else
                                {
                                    Console.Write(col + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        foreach (int[] coord in currentMove)
                        {
                            string direction = "";

                            if (coord[2] == 0)
                            {
                                direction = "up";
                            }
                            else if (coord[2] == 1)
                            {
                                direction = "right";
                            }
                            else if (coord[2] == 2)
                            {
                                direction = "down";
                            }
                            else if (coord[2] == 3)
                            {
                                direction = "left";
                            }

                            Console.WriteLine(coord[0] + ", " + coord[1] + " - " + direction);
                        }

                        Console.Read();
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (ballCount == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Solution found!");
                    foreach (int[] row in currentBoard)
                    {
                        foreach (int col in row)
                        {
                            if (col == 0)
                            {
                                Console.Write("  ");
                            }
                            else
                            {
                                Console.Write(col + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    foreach (int[] coord in currentMove)
                    {
                        string direction = "";

                        if (coord[2] == 0)
                        {
                            direction = "up";
                        }
                        else if (coord[2] == 1)
                        {
                            direction = "right";
                        }
                        else if (coord[2] == 2)
                        {
                            direction = "down";
                        }
                        else if (coord[2] == 3)
                        {
                            direction = "left";
                        }

                        Console.WriteLine(coord[0] + ", " + coord[1] + " - " + direction);
                    }
                    Console.Read();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                //boards.Add(currentBoard);
               

                mainCounter++;
            }

            Console.WriteLine("Solution found!");

            foreach (int[] row in boards[mainCounter])
            {
                foreach (int col in row)
                {
                    if (col == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(col + " ");
                    }
                }
                Console.WriteLine();
            }


            

            Console.Read();
        }
    }
}
