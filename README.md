# BlackJackApp

PEDA

P -problem

Create Black Jack game

Create deck of card that can shuffle
_Aces = 11 ALWAYS_
_Jack, Queen, King = 10_

Create one player hand and one computer hand that gets dealt 2 cards
\*dealer hand to remain hidden

Player/Computer can do following:
-choose hit until they choose to stop or bust
-choose to stand if value between 17-21
-play again when game it over

E - example

PH = PlayerHand
CH = ComputerHand
H = Hit
S = Stand
B = Bust

Example 1:

PH = 5 of Clubs & 9 of Spades = 14

CH = 4 of Clubs & Ace of Hearts = 15

Player chooses to H once = 8 of Spades = 22 B

Computer Wins!

Example 2 :

PH = 6 of Clubs & Jack of Diamonds = 16

CH = Ace of Hearts & Ace of Diamonds = 22 B

Player chooses to S

Player Wins!

Example 3:

PH = 7 of Hearts & King of Hearts = 17

CH = 2 of Diamonds & 2 of Hearts = 4

Player chooses to S

Computer chooses to H = 3 of Spades = 7
Computer chooses to H again = Queen of Spades = 17

DRAW!
Computer Wins!

Example 4:

PH = 8 of Clubs & 4 of Spades = 12

CH = Ace of Diamonds & 6 of Diamonds = 17

Player chooses to H = 2 of Spades = 14
Player chooses to H = 6 of Clubs = 20

Player Wins!

Example 5:

PH = 10 of Clubs & 7 of Hearts = 17

CH = 9 of Clubs & Queen of Clubs = 19

Player chooses to S

Computer Wins!

Example 6:

PH = 8 of Hearts & 3 of Spades = 11

CH = Jack of Hearts & 9 of Hearts = 19

Player chooses to H = 7 of Diamonds = 18
Player chooses to S
Computer Wins!

D - data structure

CARD -
Suit: Spades, Clubs, Diamonds, Hearts
Face & Values: 2=2, 3=3, 4=4, 5=5, 6=6, 7=7, 8=8, 9=9, 10=10, Jack=10, Queen=10, King=10, Ace=11

HAND -
List of cards
Total Value of cards
Add card and total new value

Shuffle -
Fisher Yates

A - algorithm

\*START

Create a CARD class including suit, face, value (AllCardsOnDeck)
Create DECK to consolidate CARDS
Shuffle cards (Fisher Yates)

Value (behavior)
if CARD 2-10 faceValue == face as value
if CARD Jack || Queen || King faceValue == 10
if CARD Ace faceValue == 11

\*DEAL (behavior)
One card to player
One card to computer
Second card to player
Second card to computer

\*HAND
hold 2 CARDS
add value of CARDS
add card per Player/computer instructions

Ask player if they want to S or H
Hit (behavior)
player gets new card
card ++ to hand value
<= 21 && > 16

Stand(behavior)
stay with current hand

Computer:
show cards
if <16, hit
if CH >=17, stand

\*/PLAYERWIN
if > PH <= 21

\*/DEALERWIN
if >= 17 && <=21 && > PH
else if CH == PH

tie == CH wins
is good while <=21
ToLower == "Stand"
Shuffle the deck
dealt cards are no longer counted in deck until hand is finished
