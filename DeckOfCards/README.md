# Deck-Of-Cards

C# implementation of a shuffle and sort of a deck of cards.

Name : Venkata Peri  
Date : Nov 21, 2022

## Program Description

Deck of Cards Problem Statement

The goal is to code in C# a program that represents a deck of poker-style playing cards. (Fifty-two playing cards in four suits: hearts, spades, clubs, diamonds, with face values of Ace, 2-10, Jack, Queen, and King.)

You should provide two operations:

shuffle()
Shuffle returns no value, but results in the cards in the deck being randomly permuted. Please do not use library-provided “shuffle” operations to implement this function. You may use library provided random number generators in your solution if needed.

dealOneCard()
This function should return one card from the deck to the caller. Specifically, a call to shuffle followed by 52 calls to dealOneCard() should result in the caller being provided all 52 cards of the deck in a random order. If the caller then makes a 53rd call dealOneCard(), no card is dealt.

## Source files

Name: Program.cs
Contains a main function for Console Application execution and
defines a Game instance. Game constructor creates the Deck instance.

Name: Deck.cs
This is the definition for the Deck Class, which holds
a list of Cards.
Functions to PlayACard, Shuffle, RestartGame, and NoOfCardsLeft.

## Circumstances of programs

The program runs successfully.

The program was developed and tested on Microsoft Visual
Studios Community 2017.

## How to build and run the program

1. Uncompress the DeckOfCards Folder and place in the
   Visual Studios Projects folder

2. Open the DeckOfCards project file in Visual Studio

3. To Run as a Console Application
   Make sure Program.cs is open in Visual Studios tab is selected
   -Hit F5 or Debug -> Start Debugging
