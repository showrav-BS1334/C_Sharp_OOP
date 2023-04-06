using C_Sharp_OOP;
using C_Sharp_OOP.OOP;
using C_Sharp_OOP.Problem14;
using C_Sharp_OOP.Problem18;
using System.Collections.Concurrent;

//Problem12 problem12 = new Problem12("Showrav");
//problem12.Solve();

//Problem13 problem13 = new Problem13();
//problem13.Solve();

//Problem14 problem14 = new Problem14();
//problem14.Solve();

//Problem15And16 problem15And16 = new Problem15And16();
//problem15And16.Solve();

//Problem18 problem18 = new Problem18();
//problem18.Solve();

//Problem19 problem19 = new Problem19();
//problem19.Solve();

//Problem20 problem20 = new Problem20();
//problem20.Solve();

/*
Problem21 problem21 = new Problem21();
problem21.Solve();*/

/*Problem22 problem22 = new Problem22();
problem22.Solve();*/

//Problem23 problem23 = new Problem23();
//problem23.Solve();

/*Problem24 problem24 = new Problem24();
problem24.Solve();*/

// special OOP
/*Problem6And7 problem6And7 = new Problem6And7();
problem6And7.Solve();

Problem3 problem3 = new Problem3();
problem3.Solve();

*/



ParentUPDOWN parent = new ParentUPDOWN();

ChildeUPDOWN child1 = (ChildeUPDOWN)parent;

child1.printParent();
child1.printChild();


ChildeUPDOWN c =  (ChildeUPDOWN)new ParentUPDOWN();
