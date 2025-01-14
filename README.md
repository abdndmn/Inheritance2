# Inheritance Example

This project demonstrates the concept of **inheritance** in C# by creating a base class `BaseKisi` and deriving specialized classes `Ogrenci` and `Ogretmen`. The program shows how inherited properties and methods can be extended to implement specific functionality.

---

## Features

### Classes

#### **1. BaseKisi (Base Class)**
- **Properties**:
  - `Ad`: Represents the first name.
  - `Soyad`: Represents the last name.
- **Method**:
  - `AdSoyad`: Prints the full name to the console.

#### **2. Ogrenci (Derived Class)**
- Inherits from `BaseKisi`.
- **Additional Property**:
  - `OgrenciNo`: Represents the student number.
- **Additional Method**:
  - `OgrenciNumber`: Prints the student number to the console.

#### **3. Ogretmen (Derived Class)**
- Inherits from `BaseKisi`.
- **Additional Property**:
  - `MaasBilgisi`: Represents the teacher's salary.
- **Additional Method**:
  - `OgretmenMaas`: Prints the teacher's salary to the console.

---

## Example Usage

### Code
```csharp
using Inheritance2;

Ogrenci ogrenci = new Ogrenci
{
    Ad = "James",
    Soyad = "Bond",
    OgrenciNo = 777,
};
ogrenci.AdSoyad();
ogrenci.OgrenciNumber();

Ogretmen ogretmen = new Ogretmen
{
    Ad = "Jason",
    Soyad = "Bourne",
    MaasBilgisi = 1000,
};
ogretmen.AdSoyad();
ogretmen.OgretmenMaas();
```

### Output
```
Adı: James
Soyadı: Bond
Ogrenci Numarası: 777

Adı: Jason
Soyadı: Bourne
Maas Bilgisi: 1000
```

---

## Concepts Demonstrated

### 1. **Inheritance**
- The `BaseKisi` class serves as the parent class for `Ogrenci` and `Ogretmen`.
- Shared properties and methods (e.g., `Ad`, `Soyad`, `AdSoyad`) are defined in the `BaseKisi` class and inherited by derived classes.

### 2. **Encapsulation**
- Properties like `Ad`, `Soyad`, `OgrenciNo`, and `MaasBilgisi` encapsulate data for each object.

### 3. **Polymorphism**
- Derived classes extend functionality by adding unique properties and methods, such as `OgrenciNumber` and `OgretmenMaas`.

---

## How to Extend

- Add additional derived classes, such as `Yonetici` or `Veli`, with their own specific properties and methods.
- Implement interfaces or abstract methods for more advanced functionality.
- Add validation logic for properties like `MaasBilgisi` or `OgrenciNo`.

---

## Summary
This example demonstrates how inheritance allows for reusability and extensibility in object-oriented programming. By using a base class, common attributes and behaviors are shared, while derived classes introduce unique features. 
