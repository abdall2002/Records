﻿// See https://aka.ms/new-console-template for more information


using System;
using C03.HashCode;

var e1 = new Employee { Id = 100, Name = "Issam" };
var e2 = new Employee { Id = 100, Name = "Issam" };
Console.WriteLine($"e1.GetHashCode() = {e1.GetHashCode()}");
Console.WriteLine($"e2.GetHashCode() = {e2.GetHashCode()}");

var c1 = new Customer { Id = 100, Name = "Issam" };
var c2 = new Customer { Id = 100, Name = "Issam" };
Console.WriteLine($"c1.GetHashCode() = {c1.GetHashCode()}");
Console.WriteLine($"c2.GetHashCode() = {c2.GetHashCode()}");

Console.WriteLine(100.GetHashCode());