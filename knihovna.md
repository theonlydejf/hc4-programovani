# 📚 Knihovna – filtrování a řazení knih

## Zadání

Dostanete seznam knih. Každá kniha má tyto informace:

- `title` – název knihy  
- `author` – autor  
- `pages` – počet stran  
- `year` – rok vydání  

Dále dostanete:

- `bookCount` – počet knih  
- `minPages` – minimální počet stran  
- `sortBy` – podle čeho se má řadit (`pages`, `title`, `author`, `year` nebo `nothing`)  
- `sortOrder` – směr řazení (`asc` nebo `desc`)  

Každá kniha je ve vstupu uložena pod klíči:

- `book0.title`, `book0.author`, `book0.pages`, `book0.year`
- `book1.title`, `book1.author`, `book1.pages`, `book1.year`
- ...

### Úkol

1. Načtěte všechny knihy ze vstupu  
2. Vyberte jen knihy, které mají alespoň `minPages` stran  
3. Pokud `sortBy` není `nothing`, seřaďte knihy podle `sortBy` a `sortOrder`  
4. Pokud `sortBy` je `nothing`, ponechte knihy v původním pořadí  
5. Vraťte seznam názvů knih (`title`)  

---

## Příklad načtení knih

```csharp
int bookCount = input.GetInt("bookCount");

for (int i = 0; i < bookCount; i++)
{
    string title = input.GetString("book" + i + ".title");
    string author = input.GetString("book" + i + ".author");
    int pages = input.GetInt("book" + i + ".pages");
    int year = input.GetInt("boo" + i + ".year");
}
```

---

## Výstup

Výstupem bude seznam názvů knih, které splní podmínku.

Například:

```json
["Duna", "Hobit"]
```

v kódu to tedy bude vypadat nějak takto:

```csharp
public object Solve(TestInput input)
{
    string[] output = new string[...];

    // Logika filtrovani a razeni

    return output;
}
```
