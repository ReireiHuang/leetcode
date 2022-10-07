// See https://aka.ms/new-console-template for more information

using Solutions;
using LeetCode.Common;
int input = (int)LeetCodeSolutions.Masking_Personal_Information;

switch (input)
{
    case (int)LeetCodeSolutions.PalindromeNumber:
        PalindromeNumber s = new PalindromeNumber();
        Console.WriteLine(s.IsPalindrome(121));
        break;
    case (int)LeetCodeSolutions.AddTwoNumber:
        AddTwoNumber s1 = new AddTwoNumber();
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        Console.WriteLine(s1.AddTwoNumbers(l1,l2).ShowNode());
        break;
    case (int)LeetCodeSolutions.StringToInteger:
        StringToInteger s2 = new StringToInteger();
        Console.WriteLine(s2.MyAtoi("+"));
        break;
    case (int)LeetCodeSolutions.Maximum_Number_of_Words_Found_in_Sentences:
        Maximum_Number_of_Words_Found_in_Sentences s3 = new Maximum_Number_of_Words_Found_in_Sentences();
        Console.WriteLine(s3.MostWordsFound(new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }));
        break;
    case (int)LeetCodeSolutions.Camelcase_Matching:
        Camelcase_Matching s4 = new Camelcase_Matching();
        s4.CamelMatch(new string[] {"CompetitiveProgramming", "CounterPick", "ControlPanel" }, "CooP");
        break;
    case (int)LeetCodeSolutions.Masking_Personal_Information:
        Masking_Personal_Information s5 = new Masking_Personal_Information();
        Console.WriteLine(s5.MaskPII("1(234)567-890"));
        break;
    default:
        break;
}

enum LeetCodeSolutions
{
    PalindromeNumber,
    AddTwoNumber,
    StringToInteger,
    Maximum_Number_of_Words_Found_in_Sentences,
    Camelcase_Matching,
    Masking_Personal_Information,
}

