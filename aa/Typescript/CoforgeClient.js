"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var coforge_1 = require("./coforge");
var objSupplier = new coforge_1.Supplier();
var res = objSupplier.supplierAddress();
var temp = (0, coforge_1.Tax)();
console.log(res, temp);
