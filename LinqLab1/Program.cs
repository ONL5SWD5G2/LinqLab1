#region part 1

#region 1
//var result1 = listgenerators.productlist.where(p => p.unitsinstock == 0);
//foreach (var p in result1)
//{
//    Console.WriteLine(p.productname);
//}
#endregion

#region 2
//var result2 = listgenerators.productlist.where(p => p.unitsinstock > 0 && p.unitprice > 5.00m);
//foreach (var p in result2)
//{
//    Console.WriteLine(p.productname);
//}
#endregion

#region 3
//string[] arr = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
//var result3 = arr.select((name, index) => new { name, index }).where(x => x.name.length < x.index).select(x => x.name);
//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//}
#endregion

#endregion

#region part 2

#region 1
//var result4 = listgenerators.productlist.select(p => p.productid);
//foreach (var id in result4)
//{
//    Console.WriteLine(id);
//}
#endregion

#region 2
//string[] words = { "mango", "peach", "kiwi" };
//var result5 = words.select(w => new { upper = w.toupper(), lower = w.tolower() });
//foreach (var item in result5)
//{
//    Console.WriteLine($"{item.upper}, {item.lower}");
//}
#endregion

#region 3
//var result6 = listgenerators.productlist.select(p => new { p.productid, p.productname, stock = p.unitsinstock });
//foreach (var p in result6)
//{
//    Console.WriteLine($"{p.productname}, stock: {p.stock}");
//}
#endregion

#region 4
//int[] arrnumbers = { 3, 1, 2, 0, 4, 9, 6, 7, 8, 5 };
//var result7 = arrnumbers.select((num, index) => new { num, index }).where(x => x.num == x.index);
//foreach (var item in result7)
//{
//    Console.WriteLine(item.num);
//}
#endregion

#region 5
//int[] numbersa = { 1, 3, 4, 6, 7, 9 };
//int[] numbersb = { 2, 4, 6, 8 };
//var result8 = from a in numbersa
//              from b in numbersb
//              where a < b
//              select new { a, b };
//foreach (var pair in result8)
//{
//    Console.WriteLine($"{pair.pair.a} is less than {pair.pair.b}");
//}
#endregion

#region 6
//var result9 = listgenerators.customerlist.selectmany(c => c.orders).where(o => o.total < 800.00m);
//foreach (var o in result9)
//{
//    Console.WriteLine(o.orderid);
//}
#endregion

#region 7
var result10 = listgenerators.customerlist.selectmany(c => c.orders).where(o => o.orderdate.year >= 1997);
foreach (var o in result10)
{
    Console.WriteLine(o.orderid);
}
#endregion

#endregion
