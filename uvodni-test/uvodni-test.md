# Programování pokročilí - Úvodní test

## 1. Sčítačka
Vytvořte program, který sečte dvě uživatelsky zadaná čísla a výsledek zobrazí.
> [!TIP]
> **Příklad vstupu a výstupu:** <br>
> Vstupy: `400`, `20` <br>
> Výstup: `420`

## 2. Dělička
Vytvořte program, který vydělí dvě uživatelsky zadaná čísla a výsledek zobrazí.
> [!TIP]
> **Příklad vstupu a výstupu:** <br>
> Vstupy: `5`, `8` <br>
> Výstup: `0.625`

## 3. Hračkářství
Ve vašem hračkářství prodáváte následující hračky:
| Hračka             | Cena |
|--------------------|------|
| LEGO stavebnice    | 200  |
| Hot Wheels autíčko | 75   |
| Panenka            | 120  |

Vytvořte program, který po zadání částky uživateli řekne, které hračky si může koupit.  
> [!TIP]
> **Příklad vstupu a výstupu:** <br>
> Vstup: `135.10` <br>
> Výstup:
> ```
> Hot Wheels autíčko (75)
> Panenka (120)
> ```

## 4. Nákupní seznam
Je dán nákupní seznam obsahující 5 položek. Program má ověřit, zda se konkrétní položka v seznamu nachází, a pokud ano, uvést její pozici.  
> [!TIP]
> **Příklad vstupů a výstupů:** <br>
> Vstup: `Jablko`, `Cibule`, `Rohlíky`, `Salám`, `Máslo`, `Jablko` <br>
> Výstup: `1`

## 5. Počítadlo samohlásek
Napište **metodu** `SpocitejSamohlasky (text) -> Číslo`, která spočítá počet samohlásek (`a, e, i, o, u, y` — včetně velkých písmen) v zadaném textu.

> [!TIP]
> **Příklad volání metody v C#:**
> ```csharp
> Console.WriteLine(SpocitejSamohlasky("Ahoj Davide"));
> ```
> **Očekávaný výstup:**  
> `5`

## 6. Reverzní text
Napište **metodu** `Reverse (text) -> Text`, která vrátí text předaný v parametru obráceně (poslední znak bude první).  
Zkuste nepoužívat vestavěné funkce.

> [!TIP]
> **Příklad volání metody v C#:**
> ```csharp
> Console.WriteLine(Reverse("Programovani"));
> ```
> **Očekávaný výstup:**  
> `inavmargorP`

## 7. Statistiky čísel
Napište **metodu** s následujícím rozhraním:

`VypocitejStatistiky (pole cisel) -> StatistikaCisel`

- Parametr `cisla` bude kolekce (seznam) celých čísel.  
- Návratovou hodnotou bude objekt třídy `StatistikaCisel`, který obsahuje tyto vlastnosti:
  - `Nejmensi` (nejmenší číslo)
  - `Nejvetsi` (největší číslo)
  - `Prumer` (průměr všech čísel, vypočtený s přesností na dvě desetinná místa)

### Třída StatistikaCisel
Třída by měla mít tri veřejné atributy/properties: `Nejmensi`, `Nejvetsi`, `Prumer`.

> [!IMPORTANT]
> **BONUS**
> Do třídy `StatistikaCisel` přidejte vlstnost `Nejcastejsi`, do které metoda vloží nejčastěji se vyskytující číslo.
> Pokud jich je více, vrátí se to nejmenší

> [!TIP]
> **Příklad volání v jazyce C# (s bonusem):**
> ```csharp
> int[] cisla = new int[] { 10, -5, 20, 10, 20, 10 };
> StatistikaCisel stat = VypocitejStatistiky(cisla);
> 
> Console.WriteLine($"Nejmenší: {stat.Nejmensi}");
> Console.WriteLine($"Největší: {stat.Nejvetsi}");
> Console.WriteLine($"Průměr: {stat.Prumer}");
> Console.WriteLine($"Nejčastější: {stat.Nejcastejsi}");
> ```
>
> **Očekávaný výstup:**
> ```
> Nejmenší: -5
> Největší: 20
> Průměr: 10.00
> Nejčastější: 10
> ```
