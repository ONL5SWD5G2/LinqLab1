#region part 1

#region 1
//var result1 = listgenerators.productlist.where(p => p.unitsinstock == 0);
//foreach (var p in result1)
//{
//    Console.WriteLine(p.productname);
//}
#endregion

#region 2
var result2 = listgenerators.productlist.where(p => p.unitsinstock > 0 && p.unitprice > 5.00m);
foreach (var p in result2)
{
    Console.WriteLine(p.productname);
}
#endregion

#endregion
