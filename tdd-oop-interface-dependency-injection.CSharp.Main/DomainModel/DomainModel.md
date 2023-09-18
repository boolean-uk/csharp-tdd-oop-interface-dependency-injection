Domain Model

Class                 | Attribute                                      | Method                   | Output
-------------------------------------------------------------------------------------------------------------------------------------------------------------
Scrabble              | letterScores Dictionary                        | score                    | Int total score of word
==============================================================================================================================================================
IScoreOfTheLetters    |                                                | GetLetterScores          | Dictionary characters and scores
==============================================================================================================================================================
EnglishLetterScores   | inherit from IScoreOfTheLetterrs               | GetLetterScores          | Dictionary English characters and scores
==============================================================================================================================================================
RussianLetterScores   | inherit from IScoreOfTheLetters                | GetLetterScores          | Dictionary Russian characters and scores
==============================================================================================================================================================
GreekLetterScores     | inherit from IScoreOfTheLetters                | GetLetterScores          | Dictionary Greek characters and scores
==============================================================================================================================================================
