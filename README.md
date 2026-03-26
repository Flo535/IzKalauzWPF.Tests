🧪 IzKalauzWPF - Unit Test Suite (NUnit)
Ez a repository az IzKalauzWPF receptkezelő alkalmazás modell rétegének egységtesztjeit tartalmazza. A projekt célja a szoftver alapvető üzleti logikájának és adatszerkezetének automatizált ellenőrzése.

🚀 Projekt célkitűzések
A tesztelés fókuszában a recept-objektumok integritása és a hibamentes adatkezelés állt, különös tekintettel a következőkre:

Null-biztonság: A belső listák (hozzávalók) automatikus példányosításának ellenőrzése.

Adatkonzisztencia: A receptek tulajdonságainak (név, kategória) pontos tárolása.

Stabilitás: A későbbi fejlesztések (API integráció, mobil app) alapjául szolgáló modellek védelme.

🛠 Alkalmazott technológiák
Keretrendszer: .NET 8.0 (Windows)

Teszt környezet: NUnit 3.14

Test Runner: Microsoft.NET.Test.Sdk

Nyelv: C# 12

📁 Struktúra
A tesztek az IzKalauzWPF.Tests névtér alatt találhatók, elkülönítve a fő alkalmazástól a moduláris felépítés érdekében.

RecipeModelTests.cs: A központi recept-modell tesztjeit tartalmazó osztály.

Usings.cs: Globális direktívák a tesztkörnyezethez.

⚙️ Tesztek futtatása
A tesztek futtatásához kövesse az alábbi lépéseket:

Klónozza a repository-t.

Nyissa meg a projektet Visual Studio 2022-ben.

A felső menüben válassza a Test -> Run All Tests opciót.

Az eredmények a Test Explorer ablakban jelennek meg.

📈 Eredmények
A jelenlegi tesztlefedettség alapján a modell réteg kritikus funkciói 100%-ban sikeresen vizsgáztak (2/2 Passed). Ez biztosítja a stabil alapot a projekt további fázisaihoz.
