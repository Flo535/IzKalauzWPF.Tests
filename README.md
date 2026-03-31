Ha a teszteknél felkiáltójelet látsz:
Mivel a fájlrendszer gépenként eltérhet, előfordulhat, hogy a Visual Studio nem találja a hivatkozást. Ekkor:
1.  Kattints jobb gombbal a `Dependencies` -> `Projects` alatt a hibás hivatkozásra és válaszd a **Remove** opciót.
2.  Kattints jobb gombbal a `Dependencies` mappára -> **Add Project Reference...**
3.  A **Browse** gombbal keresd meg a gépeden az `Izkalauz WPF.csproj` fájlt és add hozzá.
4.  Futtasd a teszteket a **Test Explorer** ablakban.
