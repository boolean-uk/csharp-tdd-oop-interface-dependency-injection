Domain Model

Class                 | Attribute                                      | Method                   | Output
-------------------------------------------------------------------------------------------------------------------------------------------------------------
Scrabble              | letterScores Dictionary                        | score                    | Int total score of word
==============================================================================================================================================================
IScoreOfTheLetters    |                                                | GetLetterScores          | Dictionary characters and scores
==============================================================================================================================================================
EnglishLetterScores   | implements from IScoreOfTheLetterrs            | GetLetterScores          | Dictionary English characters and scores
==============================================================================================================================================================
RussianLetterScores   | implements from IScoreOfTheLetters             | GetLetterScores          | Dictionary Russian characters and scores
==============================================================================================================================================================
GreekLetterScores     | implements from IScoreOfTheLetters             | GetLetterScores          | Dictionary Greek characters and scores
==============================================================================================================================================================
