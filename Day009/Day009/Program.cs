// string[] names = { "Charlie", "Alice", "Bob" };
// var sortedNames = names.OrderBy(n => n);
//
// foreach(var name in sortedNames)
// {
//     Console.WriteLine(name);
// }
//
// var firstName = names.First(n => n.StartsWith("A"));
//
// Console.WriteLine($"First name starting with A: {firstName}");

// //메서드구문 , 쿼리 구문
// int[] nums = { 5, 3, 8, 1 };
//
// //메서드구문
// var sortedMeshod = nums.OrderByDescending(n => n);
//
// //쿼리 구문
// var sortedQuery = from n in nums
//     orderby n
//     select n;
//
//
// Console.WriteLine("Meshod syntax:");
// foreach (var n in sortedMeshod)
//     Console.WriteLine(n);
//
// Console.WriteLine("Query syntax:");
// foreach (var n in sortedQuery)
// {
//     Console.WriteLine(n);
// }

//select 개념
//Linq 쿼리 연산자 중 하나
//각 요소를 변환하여 새로운 컬렉션을 생성
//
// var upperWords = words.Select(w => w.ToUpper());
//
// foreach(var word in upperWords)
// {
//     Console.WriteLine(word);
// }

