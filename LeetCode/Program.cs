using LeetCode;
using static LeetCode._0083_Remove_Duplicates_from_Sorted_List;
using static LeetCode._0141_Linked_List_Cycle;

Console.WriteLine("#1. Two Sum");
_0001_Two_Sum two_Sum = new _0001_Two_Sum();
int[] input_1 = { 2, 7, 11, 15 };
int target_1 = 9;
var result_1 = (two_Sum.TwoSum(input_1, target_1));
foreach (var item in result_1)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n#35. Search Insert Position");
_0035_Search_Insert_Position search_Insert_Position = new _0035_Search_Insert_Position();
int[] input_35 = { 1, 3, 5, 6 };
int target_35 = 5;
Console.WriteLine(search_Insert_Position.SearchInsert(input_35, target_35));


Console.WriteLine("\n#58. Length of Last Word");
_0058_Length_of_Last_Word length_Of_Last_Word = new _0058_Length_of_Last_Word();
string input_58 = "a ";
Console.WriteLine(length_Of_Last_Word.LengthOfLastWord(input_58));


Console.WriteLine("\n#66. Plus One");
_0066_Plus_One plus_One = new _0066_Plus_One();
int[] input_66 = { 9 };
var result_66 = plus_One.PlusOne(input_66);
foreach (var item in result_66)
{
    Console.Write(item);
}
Console.WriteLine();


Console.WriteLine("\n#67. Add Binary");
_0067_Add_Binary add_Binary = new _0067_Add_Binary();
string input_67_1 = "1011";
string input_67_2 = "1011";
Console.WriteLine(add_Binary.AddBinary(input_67_1, input_67_2));


Console.WriteLine("\n#69. Sqrt(x)");
_0069_Sqrt_x_ sqrt_X_ = new _0069_Sqrt_x_();
int input_69 = 12;
Console.WriteLine(sqrt_X_.MySqrt_V2(input_69));


Console.WriteLine("\n#70. Climbing Stairs");
_0070_Climbing_Stairs climbing_Stairs = new _0070_Climbing_Stairs();
int input_70 = 10;
Console.WriteLine(climbing_Stairs.ClimbStairs(input_70));


Console.WriteLine("\n#83. Remove Duplicates from Sorted List");
_0083_Remove_Duplicates_from_Sorted_List remove_Duplicates_From_Sorted_List = new _0083_Remove_Duplicates_from_Sorted_List();
_0083_Remove_Duplicates_from_Sorted_List.ListNode input_83 = new _0083_Remove_Duplicates_from_Sorted_List.ListNode(1);
var result_83 = remove_Duplicates_From_Sorted_List.DeleteDuplicates(input_83);
Console.WriteLine(result_83);


Console.WriteLine("\n#88. Merge Sorted Array");
_0088_Merge_Sorted_Array merge_Sorted_Array = new _0088_Merge_Sorted_Array();
int[] input_88_nums1 = { 1, 2, 3, 0, 0, 0 };
int input_88_m = 3;
int[] input_88_nums2 = { 2, 5, 6 };
int input_88_n = 3;
merge_Sorted_Array.Merge_V2(input_88_nums1, input_88_m, input_88_nums2, input_88_n);
foreach (var item in input_88_nums1)
{
    Console.Write(item);
}
Console.WriteLine();


Console.WriteLine("\n#118. Pascal's Triangle");
_0118_Pascal_s_Triangle pascal_S_Triangle = new _0118_Pascal_s_Triangle();
int input_118 = 5;
var result_118 = pascal_S_Triangle.Generate(input_118);
foreach (var item in result_118)
{
    foreach (var i in item)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}
Console.WriteLine();


Console.WriteLine("\n#119. Pascal's Triangle II");
_0119_Pascal_s_Triangle_II pascal_S_Triangle_II = new _0119_Pascal_s_Triangle_II();
int input_119 = 5;
var result_119 = pascal_S_Triangle_II.GetRow(input_119);
foreach (var item in result_119)
{
    Console.Write(item);
}
Console.WriteLine();


Console.WriteLine("\n#121. Best Time to Buy and Sell Stock");
_0121_Best_Time_to_Buy_and_Sell_Stock best_Time_To_Buy_And_Sell_Stock = new _0121_Best_Time_to_Buy_and_Sell_Stock();
int[] input_121 = { 7, 1, 5, 3, 6, 4 };
Console.WriteLine(best_Time_To_Buy_And_Sell_Stock.MaxProfit(input_121));


Console.WriteLine("\n#125. Valid Palindrome");
_0125_Valid_Palindrome valid_Palindrome = new _0125_Valid_Palindrome();
string input_125 = "A man, a plan, a canal: Panama";
Console.WriteLine(valid_Palindrome.IsPalindrome(input_125));


Console.WriteLine("\n#136. Single Number");
_0136_Single_Number single_Number = new _0136_Single_Number();
int[] input_136 = { 4, 1, 2, 1, 2 };
Console.WriteLine(single_Number.SingleNumber(input_136));


Console.WriteLine("\n#141. Linked List Cycle");
_0141_Linked_List_Cycle linked_List_Cycle = new _0141_Linked_List_Cycle();
_0141_Linked_List_Cycle.ListNode input_141 = new _0141_Linked_List_Cycle.ListNode(1);
var result_141 = linked_List_Cycle.HasCycle_V1(input_141);
Console.WriteLine(result_141);


Console.WriteLine("\n#160. Intersection of Two Linked Lists");
_0160_Intersection_of_Two_Linked_Lists intersection_Of_Two_Linked_Lists = new _0160_Intersection_of_Two_Linked_Lists();
_0160_Intersection_of_Two_Linked_Lists.ListNode input_160_1 = new _0160_Intersection_of_Two_Linked_Lists.ListNode(1);
_0160_Intersection_of_Two_Linked_Lists.ListNode input_160_2 = new _0160_Intersection_of_Two_Linked_Lists.ListNode(2);
var result_160 = intersection_Of_Two_Linked_Lists.GetIntersectionNode(input_160_1, input_160_2);
Console.WriteLine(result_160);


Console.WriteLine("\n#168. Excel Sheet Column Title");
_0168_Excel_Sheet_Column_Title excel_Sheet_Column_Title = new _0168_Excel_Sheet_Column_Title();
int input_168 = 701;
Console.WriteLine(excel_Sheet_Column_Title.ConvertToTitle(input_168));


Console.WriteLine("\n#169. Majority Element");
_0169_Majority_Element majority_Element = new _0169_Majority_Element();
int[] input_169 = { 2, 2, 1, 1, 1, 2, 2 };
Console.WriteLine(majority_Element.MajorityElement(input_169));


Console.WriteLine("\n#171. Excel Sheet Column Number");
_0171_Excel_Sheet_Column_Number excel_Sheet_Column_Number = new _0171_Excel_Sheet_Column_Number();
string input_171 = "AB";
Console.WriteLine(excel_Sheet_Column_Number.TitleToNumber(input_171));


Console.WriteLine("\n#190. Reverse Bits");
_0190_Reverse_Bits reverse_Bits = new _0190_Reverse_Bits();
uint input_190 = 00000000000000000000000010000000;
Console.WriteLine(reverse_Bits.reverseBits(input_190));


Console.WriteLine("\n#191. Number of 1 Bits");
_0191_Number_of_1_Bits number_Of_1_Bits = new _0191_Number_of_1_Bits();
uint input_191 = 00000000000000000000000010000000;
Console.WriteLine(number_Of_1_Bits.HammingWeight(input_191));


Console.WriteLine("\n#202. Happy Number");
_0202_Happy_Number _Happy_Number = new _0202_Happy_Number();
int input_202 = 19;
Console.WriteLine(_Happy_Number.IsHappy(input_202));


Console.WriteLine("\n#217. Contains Duplicate");
_0217_Contains_Duplicate contains_Duplicate = new _0217_Contains_Duplicate();
int[] input_217 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
Console.WriteLine(contains_Duplicate.ContainsDuplicate(input_217));


Console.WriteLine("\n#219. Contains Duplicate II");
_0219_Contains_Duplicate_II contains_Duplicate_II = new _0219_Contains_Duplicate_II();
int[] input_219 = { 1, 2, 3, 1, 2, 3 };
int input_219_2 = 2;
Console.WriteLine(contains_Duplicate_II.ContainsNearbyDuplicate(input_219, input_219_2));


Console.WriteLine("\n#228. Summary Ranges");
_0228_Summary_Ranges summary_Ranges = new _0228_Summary_Ranges();
int[] input_228 = { 0, 1, 2, 4, 5, 7 };
var result_228 = summary_Ranges.SummaryRanges(input_228);
foreach (var item in result_228)
{
    Console.Write(item);
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("\n#268. Missing Number");
_0268_Missing_Number missing_Number = new _0268_Missing_Number();
int[] input_268 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
Console.WriteLine(missing_Number.MissingNumber_V2(input_268));


Console.WriteLine("\n#283. Move Zeroes");
_0283_Move_Zeroes move_Zeroes = new _0283_Move_Zeroes();
int[] input_283 = { 0, 1, 0, 3, 12 };
move_Zeroes.MoveZeroes_V2(input_283);
foreach (var item in input_283)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#338. Counting Bits");
_0338_Counting_Bits counting_Bits = new _0338_Counting_Bits();
int input_338 = 15;
var resilt_338 = counting_Bits.CountBits_V2(input_338);
foreach (var item in resilt_338)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#345. Reverse Vowels of a String");
_0345_Reverse_Vowels_of_a_String reverse_Vowels_Of_A_String = new _0345_Reverse_Vowels_of_a_String();
string input_345 = "Aa";
Console.WriteLine(reverse_Vowels_Of_A_String.ReverseVowels(input_345));


Console.WriteLine("\n#349. Intersection of Two Arrays");
_0349_Intersection_of_Two_Arrays intersection_Of_Two_Arrays = new _0349_Intersection_of_Two_Arrays();
int[] input_349_1 = { 1, 2, 2, 1 };
int[] input_349_2 = { 2, 2 };
var result_349 = intersection_Of_Two_Arrays.Intersection(input_349_1, input_349_2);
foreach (var item in result_349)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#350. Intersection of Two Arrays II");
_0350_Intersection_of_Two_Arrays_II intersection_Of_Two_Arrays_II = new _0350_Intersection_of_Two_Arrays_II();
int[] input_350_1 = { 4, 9, 5 };
int[] input_350_2 = { 9, 4, 9, 8, 4 };
var result_350 = intersection_Of_Two_Arrays_II.Intersect_V2(input_350_1, input_350_2);
foreach (var item in result_350)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#414. Third Maximum Number");
_0414_Third_Maximum_Number third_Maximum_Number = new _0414_Third_Maximum_Number();
int[] input_414 = { 3, 2, 1 };
Console.WriteLine(third_Maximum_Number.ThirdMax(input_414));


Console.WriteLine("\n#448. Find All Numbers Disappeared in an Array");
_0448_Find_All_Numbers_Disappeared_in_an_Array find_All_Numbers_Disappeared_In_An_Array = new _0448_Find_All_Numbers_Disappeared_in_an_Array();
int[] input_448 = { 4, 3, 2, 7, 8, 2, 3, 1 };
var result_448 = find_All_Numbers_Disappeared_In_An_Array.FindDisappearedNumbers_V4(input_448);
foreach (var item in result_448)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#455. Assign Cookies");
_0455_Assign_Cookies assign_Cookies = new _0455_Assign_Cookies();
int[] input_455_1 = { 1, 2 };
int[] input_455_2 = { 1, 2, 3 };
Console.WriteLine(assign_Cookies.FindContentChildren(input_455_1, input_455_2));


Console.WriteLine("\n#463. Island Perimeter");
_0463_Island_Perimeter island_Perimeter = new _0463_Island_Perimeter();
int[][] input_463 = new int[][]
{
    new int[] { 0, 1, 0, 0 },
    new int[] { 1, 1, 1, 0 },
    new int[] { 0, 1, 0, 0 },
    new int[] { 1, 1, 0, 0 },
};
Console.WriteLine(island_Perimeter.IslandPerimeter(input_463));


Console.WriteLine("\n#485. Max Consecutive Ones");
_0485_Max_Consecutive_Ones max_Consecutive_Ones = new _0485_Max_Consecutive_Ones();
int[] input_485 = { 1, 0, 1, 1, 0, 1 };
Console.WriteLine(max_Consecutive_Ones.FindMaxConsecutiveOnes(input_485));


Console.WriteLine("\n#495. Teemo Attacking");
_0495_Teemo_Attacking teemo_Attacking = new _0495_Teemo_Attacking();
int[] input_495_1 = { 1, 4 };
int input_495_2 = 2;
Console.WriteLine(teemo_Attacking.FindPoisonedDuration(input_495_1, input_495_2));


Console.WriteLine("\n#496. Next Greater Element I");
_0496_Next_Greater_Element_I next_Greater_Element_I = new _0496_Next_Greater_Element_I();
int[] input_496_1 = { 4, 1, 2 };
int[] input_496_2 = { 1, 3, 4, 2 };
var result_496 = next_Greater_Element_I.NextGreaterElement(input_496_1, input_496_2);
foreach (var item in result_496)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#500. Keyboard Row");
_0500_Keyboard_Row keyboard_Row = new _0500_Keyboard_Row();
string[] input_500 = { "Hello", "Alaska", "Dad", "Peace" };
var result_500 = keyboard_Row.FindWords(input_500);
foreach (var item in result_500)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#506. Relative Ranks");
_0506_Relative_Ranks relative_Ranks = new _0506_Relative_Ranks();
int[] input_506 = { 10, 3, 8, 9, 4 };
var result_506 = relative_Ranks.FindRelativeRanks(input_506);
foreach (var item in result_506)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#561. Array Partition");
_0561_Array_Partition array_Partition = new _0561_Array_Partition();
int[] input_561 = { 6, 2, 6, 5, 1, 2 };
Console.WriteLine(array_Partition.ArrayPairSum(input_561));


Console.WriteLine("\n#566. Reshape the Matrix");
_0566_Reshape_the_Matrix reshape_The_Matrix = new _0566_Reshape_the_Matrix();
int[][] input_566 = new int[][]
{
    new int[] { 1, 2},
    new int[] { 3, 4},
};
int input_566_r = 1;
int input_566_c = 4;
var result_566 = reshape_The_Matrix.MatrixReshape_V2(input_566, input_566_r, input_566_c);
foreach (var item in result_566)
{
    foreach (var i in item)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();


Console.WriteLine("\n#575. Distribute Candies");
_0575_Distribute_Candies distribute_Candies = new _0575_Distribute_Candies();
int[] input_575 = { 6, 6, 6, 6 };
Console.WriteLine(distribute_Candies.DistributeCandies(input_575));


Console.WriteLine("\n#594. Longest Harmonious Subsequence");
_0594_Longest_Harmonious_Subsequence longest_Harmonious_Subsequence = new _0594_Longest_Harmonious_Subsequence();
int[] input_594 = { 1, 3, 2, 2, 5, 2, 3, 7 };
Console.WriteLine(longest_Harmonious_Subsequence.FindLHS(input_594));


Console.WriteLine("\n#598. Range Addition II");
_0598_Range_Addition_II range_Addition_II = new _0598_Range_Addition_II();
int input_598_1 = 3;
int input_598_2 = 3;
int[][] input_598_3 = new int[][]
{
    new int[] { 2,2 },
    new int[] { 3,3 },
};
Console.WriteLine(range_Addition_II.MaxCount(input_598_1, input_598_2, input_598_3));


Console.WriteLine("\n#599. Minimum Index Sum of Two Lists");
_0599_Minimum_Index_Sum_of_Two_Lists minimum_Index_Sum_Of_Two_Lists = new _0599_Minimum_Index_Sum_of_Two_Lists();
string[] input_599_1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
string[] input_599_2 = { "KFC", "Shogun", "Burger King" };
var result_599 = minimum_Index_Sum_Of_Two_Lists.FindRestaurant(input_599_1, input_599_2);
foreach (var item in result_599)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#605. Can Place Flowers");
_0605_Can_Place_Flowers can_Place_Flowers = new _0605_Can_Place_Flowers();
int[] input_605_1 = { 1, 0, 0, 0, 1 };
int input_605_2 = 2;
Console.WriteLine(can_Place_Flowers.CanPlaceFlowers(input_605_1, input_605_2));


Console.WriteLine("\n#628. Maximum Product of Three Numbers");
_0628_Maximum_Product_of_Three_Numbers maximum_Product_Of_Three_Numbers = new _0628_Maximum_Product_of_Three_Numbers();
int[] input_628 = { -100, -98, -1, 2, 3, 4 };
Console.WriteLine(maximum_Product_Of_Three_Numbers.MaximumProduct(input_628));


Console.WriteLine("\n#643. Maximum Average Subarray I");
_0643_Maximum_Average_Subarray_I maximum_Average_Subarray_I = new _0643_Maximum_Average_Subarray_I();
int[] input_643_1 = { 5 };
int input_643_2 = 1;
Console.WriteLine(maximum_Average_Subarray_I.FindMaxAverage_V2(input_643_1, input_643_2));


Console.WriteLine("\n#645. Set Mismatch");
_0645_Set_Mismatch set_Mismatch = new _0645_Set_Mismatch();
int[] input_645 = { 2, 2 };
var result_645 = set_Mismatch.FindErrorNums(input_645);
foreach (var item in result_645)
{
    Console.Write(item + " ");
}
Console.WriteLine();


Console.WriteLine("\n#674. Longest Continuous Increasing Subsequence");
_0674_Longest_Continuous_Increasing_Subsequence longest_Continuous_Increasing_Subsequence = new _0674_Longest_Continuous_Increasing_Subsequence();
int[] input_674 = { 1, 3, 5, 4, 7 };
Console.WriteLine(longest_Continuous_Increasing_Subsequence.FindLengthOfLCIS(input_674));


Console.WriteLine("\n#682. Baseball Game");
_0682_Baseball_Game baseball_Game = new _0682_Baseball_Game();
string[] input_682 = { "5", "-2", "4", "C", "D", "9", "+", "+" };
Console.WriteLine(baseball_Game.CalPoints(input_682));


//Console.WriteLine("\n#697. Degree of an Array");
//_0697_Degree_of_an_Array degree_Of_An_Array = new _0697_Degree_of_an_Array();
//int[] input_697 = { 1, 2, 2, 3, 1 };
//Console.WriteLine(degree_Of_An_Array.FindShortestSubArray(input_697));


Console.WriteLine("\n#704. Binary Search");
_0704_Binary_Search binary_Search = new _0704_Binary_Search();
int[] input_704_1 = { -1, 0, 3, 5, 9, 12 };
int input_704_2 = 2;
Console.WriteLine(binary_Search.Search(input_704_1, input_704_2));


Console.WriteLine("\n#717. 1-bit and 2-bit Characters");
_0717_1_bit_and_2_bit_Characters _1_bit_And_2_Bit_Characters = new _0717_1_bit_and_2_bit_Characters();
int[] input_717 = { 1, 1, 0, 0 };
Console.WriteLine(_1_bit_And_2_Bit_Characters.IsOneBitCharacter(input_717));


Console.WriteLine("\n#724. Find Pivot Index");
_0724_Find_Pivot_Index find_Pivot_Index = new _0724_Find_Pivot_Index();
int[] input_724 = { 1, 7, 3, 6, 5, 6 };
Console.WriteLine(find_Pivot_Index.PivotIndex(input_724));


Console.WriteLine("\n#771. Jewels and Stones");
_0771_Jewels_and_Stones jewels_And_Stones = new _0771_Jewels_and_Stones();
string input_771_1 = "aA";
string input_771_2 = "aAAbbbb";
Console.WriteLine(jewels_And_Stones.NumJewelsInStones_V1(input_771_1, input_771_2));


Console.WriteLine("\n#804. Unique Morse Code Words");
_0804_Unique_Morse_Code_Words unique_Morse_Code_Words = new _0804_Unique_Morse_Code_Words();
string[] input_804 = { "gin", "zen", "gig", "msg" };
Console.WriteLine(unique_Morse_Code_Words.UniqueMorseRepresentations(input_804));


Console.WriteLine("\n#1365. How Many Numbers Are Smaller Than the Current Number");
_1365_How_Many_Numbers_Are_Smaller_Than_the_Current_Number how_Many_Numbers_Are_Smaller_Than_The_Current_Number = new _1365_How_Many_Numbers_Are_Smaller_Than_the_Current_Number();
int[] input_1365 = { 8, 1, 2, 2, 3 };
var result_1365 = how_Many_Numbers_Are_Smaller_Than_The_Current_Number.SmallerNumbersThanCurrent(input_1365);
foreach (var item in result_1365)
{
    Console.Write(item);
}
Console.WriteLine();


Console.WriteLine("\n#1512. Number of Good Pairs");
_1512_Number_of_Good_Pairs number_Of_Good_Pairs = new _1512_Number_of_Good_Pairs();
int[] input_1512 = { 1, 2, 3, 1, 1, 3 };
Console.WriteLine(number_Of_Good_Pairs.NumIdenticalPairs_v3(input_1512));


Console.WriteLine("\n#1920. Build Array from Permutation");
_1920_Build_Array_from_Permutation build_Array_From_Permutation = new _1920_Build_Array_from_Permutation();
int[] input_1920 = { 0, 2, 1, 5, 3, 4 };
var result_1920 = build_Array_From_Permutation.BuildArray(input_1920);
foreach (var item in result_1920)
{
    Console.Write(item);
}
Console.WriteLine();


Console.WriteLine("\n#2006. Count Number of Pairs With Absolute Difference K");
_2006_Count_Number_of_Pairs_With_Absolute_Difference_K count_Number_Of_Pairs_With_Absolute_Difference_K = new _2006_Count_Number_of_Pairs_With_Absolute_Difference_K();
int[] input_2006_1 = { 1, 2, 2, 1 };
int input_2006_2 = 1;
Console.WriteLine(count_Number_Of_Pairs_With_Absolute_Difference_K.CountKDifference(input_2006_1, input_2006_2));


Console.WriteLine("\n#2325. Decode the Message");
_2325_Decode_the_Message decode_The_Message = new _2325_Decode_the_Message();
string input_2325_1 = "the quick brown fox jumps over the lazy dog";
string input_2325_2 = "vkbs bs t suepuv";
Console.WriteLine(decode_The_Message.DecodeMessage(input_2325_1, input_2325_2));


Console.WriteLine("\n#2367. Number of Arithmetic Triplets");
_2367_Number_of_Arithmetic_Triplets number_Of_Arithmetic_Triplets = new _2367_Number_of_Arithmetic_Triplets();
int[] input_2367_1 = { 0, 1, 4, 6, 7, 10 };
int input_2367_2 = 3;
Console.WriteLine(number_Of_Arithmetic_Triplets.ArithmeticTriplets(input_2367_1, input_2367_2));