# peg-solitare
Program that (aims to) solve the common peg or marble solitare board game.

Rules, initial boards and more for this puzzle are [as follows](https://en.wikipedia.org/wiki/Peg_solitaire). 

# Disclamer
This is not a solution to the problem. Although I am confident it would find a solution given enough processing power and time, it is horribly inefficient and would benefit from being recreated using backtracking or through implementing some combinatorial algorithm.

I only spent a couple of hours on this program (back before I greatly developed my programming), hence the horrible commenting and formatting of the code and memory leaking. If you can suggest a better way of tackling this problem, let me know!

# Using the program
As soon as the program is loaded, it will start looking for solutions. Once it finds a solution that has 2 or less marbles remaining, it will prompt you to view the solution. If you press v when it asks if you want to view the solution, a final board will be displayed, along with the coordinates and directions that the marbles need to move in order to reach that final board.

If the solution is found, execution will stop and the solution is displayed.
