# StringCompare
Library class to compare strings in a relative way.

# HISTORY
I had written a code for my project to detect similar names approximately from database.
first I used the DIFFERENCE(string1, string2) >= 4 function of SQL server but it didn't help me because for example 
when first name was "21" and second name was "21 jump street" the result contained two names whereas obviously they didn't even 
similar. so the result set of such a query contained over 700 values that was very poor in this case.
then I found a similar DIFFERENCE function for c# that was nearly the same as SQL version of that function. for example 
it matched the similarity of "asdcdfsdfgdsgdg" and "asdewwetqwetrwe" as perfect which is obviously not true.
then I created a class library for this issue to get more efficient similarity between strings.

# WHAT IS STRING COMPARE
StringCompare is a comparing tool for strings. not an ordinal comparison, but a relative comparison that 
determines how much two strings are similar or how much not similar.
by setting the good tradeoff values you can get a good comparison for strings.

# HOW TO USE IT
first you should setup an instance of StringCompare with custom or default tradeoff values.

there are 4 values that should be set:

1. MinSimilarityLong (percentage):
   this is the minimum acceptable percentage of similarity between two strings.
   this value will be used for strings with the length of at least 8.

2. MinSimilarityShort (percentage):
   this is the minimum acceptable percentage of similarity between two strings.
   this value will be used for strings with the length below 8.

3. MaxToleranceLong (percentage):
   this is the maximum acceptable percentage of tolerance between two strings.
   this value will be used for strings with the length of at least 8.

4. MaxToleranceShort (percentage):
   this is the maximum acceptable percentage of tolerance between two strings.
   this value will be used for strings with the length below 8.

* once you have created an instance you can call InstanceName.IsEqual(string1, string2) to determine the equality of two strings.
* consider that the equality is relative to the minSimilarty and maxTolerance you have set before.
* consider that higher minSimilarity values will result in more restricted results and vice versa.
* consider that lower maxTolerance values will result in more restricted results and vice versa.

# EXAMPLE
if you set minSimilarity = 100 && maxTolerance = 0
then only strings that are exactly the same will be considered as equal.
if you set minSimilarity = 0 && maxTolerance = 100
then all strings will be considered as equal.

* so it's important to use the minSimilarity and maxTolerance together and not individually to get efficient results.

# FAQ

1. what is the meaning of similarity?
   similarity determines how much common letters should be available between two strings to be considered equal.

2. what is the meaning of tolerance?
   tolerance determines how much the same characters of two strings are allowed to be in none-ordinal indices to be considered equal.

3. why is there two minSimilarity and two maxTolerance values (Long and Short)?
   it's a trick to get more reliable comparison on any string, because on short strings when you set the minSimilarity 
   same as long strings you will get more restricted results so it's better to set minSimilarityShort lower than minSimilarityLong.
   it goes the same for maxTolerance, so it's better to set maxToleranceShort lower than maxToleranceLong.

* finally, it depends on your application and purpose of comparing strings in your app, and also on your data to be compared.
  so you should test this class with different tradeoff values to get the best and more efficient minSimilarity and maxTolerance 
  values for your case.

# HOW TO TRY IT
the solution contains a WinForm application which lets you test StringCompare with different tradeoff values.
