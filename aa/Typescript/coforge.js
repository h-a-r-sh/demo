"use strict";
// class Employee
// {
//     ID:number;
//     Age:number;
//     Name:string;
//     constructor(i:number,a:number,n:string){
//         this.ID=i;
//         this.Name=n;
//         this.Age=a;
//     }
//     GetEmployee():void{
//         console.log(this.Name);
//     }
//     GetAge():number{
//         return this.Age;
//     }
Object.defineProperty(exports, "__esModule", { value: true });
exports.Supplier = void 0;
exports.Tax = Tax;
// }
// let objEmp=new Employee(1,22,"Ashish");
// objEmp.GetEmployee();
// let temp=objEmp.GetAge();
// console.log(temp);
var Supplier = /** @class */ (function () {
    function Supplier() {
    }
    Supplier.prototype.supplierAddress = function () {
        return "noida";
    };
    return Supplier;
}());
exports.Supplier = Supplier;
function Tax() {
    return 200;
}
var Deprtment = /** @class */ (function () {
    function Deprtment() {
    }
    Deprtment.prototype.supplierAddress = function () {
        return "Gr. noida";
    };
    return Deprtment;
}());
var temp = new Deprtment();
console.log(temp.supplierAddress());
