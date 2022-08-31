// See https://aka.ms/new-console-template for more information

using Leetcode;
using LeetCode.Common;
int input = (int)LeetCodeSolutions.AddTwoNumber;

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
    default:
        break;
}

enum LeetCodeSolutions
{
    PalindromeNumber,
    AddTwoNumber
}
