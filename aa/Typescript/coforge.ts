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

// }
// let objEmp=new Employee(1,22,"Ashish");
// objEmp.GetEmployee();
// let temp=objEmp.GetAge();
// console.log(temp);

export class Supplier
{
    supplierAddress():string
    {
        return "noida";
    }
}


export function Tax()
{
    return 200;
}


class Deprtment
{
    supplierAddress():string
    {
        return "Gr. noida";
    }
}

let temp=new Deprtment();
console.log(temp.supplierAddress());
