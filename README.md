# StringCompare
Class library for comparing strings in a relative way.

# HISTORY
I had written some code for my project to approximate similar names from a database.
First I used the DIFFERENCE(string1, string2) >= 4 function of SQL Server but it didn't help me because for example 
if the first name was "21" and the second name was "21 jump street", the result contained two names, whereas obviously they weren't even similar. 
So the result set of such a query contained over 700 values, which was very bad in this case.
Then I found a similar DIFFERENCE function for C# that was almost the same as the SQL version of this function. For example 
It matched the similarity of "asdcdfsdfgdsgdg" and "asdewwetqwetrwe" as perfect, which is obviously not true.
I then created a class library for this problem to get more efficient similarity between strings.

# WHAT IS STRING COMPARE
StringCompare is a comparison tool for strings. It is not an ordinal comparison, but a relative comparison that determines 
how much two strings are similar or dissimilar. by setting the good tradeoff values, you can get a good comparison for strings.

# HOW TO USE IT
First you should set up an instance of StringCompare with custom or default tradeoff values.

There are 4 values to be set:

1. MinSimilarityLong (%):
   this is the minimum acceptable percentage of similarity between two strings.
   this value is used for strings that are at least 8 characters long.

3. MinSimilarityShort (%):
   this is the minimum acceptable percentage of similarity between two strings.
   this value is used for strings less than 8 characters in length.

5. MaxToleranceLong (%):
   this is the maximum acceptable percentage of tolerance between two strings.
   this value is used for strings with a length of 8 or more.

7. MaxToleranceShort (%):
   this is the maximum acceptable percentage of tolerance between two strings.
   this value is used for strings less than 8 in length.

* Once you have created an instance, you can call InstanceName.IsEqual(string1, string2) to test the equality of two strings.
* Note that the equality is relative to the minSimilarity and maxTolerance you set earlier.
* Note that higher minSimilarity values will produce more restricted results and vice versa.
* Note that lower maxTolerance values will produce more restricted results and vice versa.

# EXAMPLE
If you set minSimilarity = 100 && maxTolerance = 0, only strings that are exactly the same will be considered equal. 
If you set minSimilarity = 0 && maxTolerance = 100, all strings will be considered equal.

* So it's important to use minSimilarity and maxTolerance together, not separately, to get efficient results.

# FAQ

1. What does similarity mean?
   Similarity determines how many common letters there should be between two strings to be considered similar.

2. What is tolerance?
   Tolerance determines how far apart the same characters of two strings may be in non-ordinal indices in order to be considered equal.

3. Why are there two minSimilarity and two maxTolerance values (long and short)?
   It's a trick to get a more reliable comparison on any string, because on short strings if you set minSimilarity the same as
   long strings you'll get more restricted results, so it's better to set minSimilarityShort lower than minSimilarityLong.
   it goes the same for maxTolerance, so it's better to set maxToleranceShort lower than maxToleranceLong.

* Finally, it depends on your application and the purpose of comparing strings in your application, and also on your data
  to be compared, so you should test this class with different trade-off values to get the best and most efficient
  minSimilarity and maxTolerance values for your case.

# HOW TO TRY IT
The solution includes a WinForm application that allows you to test StringCompare with different tradeoff values.
