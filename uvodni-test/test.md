# Programování pokročílí - Úvodní test

### 1. Sčítačka
Program sečte dvě uživatelem zadaná čísla a výsledek zobrazí.
> **Příklad vstupu a výstupu:** <br>
>
> Vstupy: `400`, `20` <br>
> Výstup: `420`

### 2. Dělička
Program vydělí dvě uživatelem zadaná čísla a výsledek zobrazí.
> **Příklad vstupu a výstupu:** <br>
>
> Vstupy: `5`, `8` <br>
> Výstup: `0.625`

### 3. Hračkářství
Ve vašem hračkářství prodáváte následující hračky:
| Hračka             | Cena |
|--------------------|------|
| LEGO stavebnice    | 200  |
| Hot Wheels autíčko | 75   |
| Panenka            | 120  |

Vytvořte program, který po zadání částky uživateli řekne, které hračky si může koupit. Ke každé hračce ve výstupu připište její cenu <br>
*(ceny jsou uzavřeny v závorkách, na pořadí předmětů nezáleží)*
> **Příklad vstupu a výstupu:** <br>
>
> Vstup: `135.10` <br>
> Výstup:
> ```
> Hot Wheels autíčko (75)
> Panenka (120)
> ```

### 4. Nákupní seznam
Je dán nákupní seznam obsahující 5 položek. Vaším úkolem je napsat program, který ověří, zda se konkrétní položka v seznamu nachází, a pokud ano, uvede její pozici. Položky seznamu a hledaná položka jsou zadávány jako vstup. Nejprve jsou zadány položky seznamu, poté (tedy jako poslední) následuje položka, kterou chcete vyhledat.
> **Příklad vstupu a výstupu:** <br>
>
>> Vstup: `Jablko`, `Cibule`, `Rohlíky`, `Salám`, `Máslo`, `Jablko` <br>
>> Výstup: `1`
>
>> Vstup: `Chipsy`, `Mražená pizza`, `Kedluben`, `Banány`, `Sušenka`, `Kedluben` <br>
>> Výstup: `3`
>
>> Vstup: `Chipsy`, `Mražená pizza`, `Kedluben`, `Banány`, `Sušenka`, `Nůžky` <br>
>> Výstup: `Položka se v seznamu nenachází`

### $${\textcolor{gold}5. Hračkářství s širokou nabídkou}$$
Cílem je vytvořit podobný program jako ve cvičení 3. Nabízené hračky a jejich ceny ale nejsou dopředu známé, jsou tedy obsaženy jako součást vstupu. Vaše hračkářství má na skladě vždy 5 druhů hraček. Nikdy méně ani více.

> **Příklad vstupu a výstupu:** <br>
>
> Vstup: `Míč`, `23`, `Dřevěná kachna`, `60`, `Robot`, `200`, `Vojáček`, `50`, `Hlavolam`, `80`, `50` <br>
> Výstup:
> ```
> Míč (23)
> Vojáček (50)
> ```

### 6. Nerozbitná kalkulačka </span>
Vytvořte jednoduchou kalulačku kterou nebude možné rozbít. Program jako vstup dostane dvě čísla a jednu z možných matematických operací (+, -, *, /), kterou má na daná čísla aplikovat. Vaším úkolem je program vytvořit a ošetřit tak, aby ho nebylo možné jakýmkoliv způsobem rozbít (aby nevyvolal vyjímku, lidsky řečeno "nespadla"). Pokud program detekuje špatný vstup, uživatele o tom velmi přesně informuje (viz Příklady vstupů a výstupů)

> **Příklad vstupů a výstupů:** <br>
>
>> Vstup: `1`, `2`, `+` <br>
>> Výstup: `3`
>
>> Vstup: `1`, `-2.5`, `/` <br>
>> Výstup: `-0.4`
>
>> Vstup: `$$`, `68`, `/` <br>
>> Výstup: `První vstupní číslo není platná číselná hodnota`
>
>> Vstup: `42`, `10`, `@` <br>
>> Výstup: `Neznámá operace`

> ### Vysvětlivka pro definici rozhraní metod
> `Název metody` (`parametr1`, `parametr2`) -> `Návratová hodnota`
>
> **Příklad:**<br>
> `Secti (cislo1, cislo2) -> Číslo` <br><br>
> Metoda výše se má jmenovat `Secti`, má dva parametry s názvy `cislo1` a `cislo2` a bude vracet číselnou hodnotu. V definici rozhraní není stanoven datový typ, to je naschvál. Toto rozhodnutí je ponecháno na vás.

### 7. Je to palindrom?
Palindrom je číslo, které je při přečtení z obou stran stejné. Například čísla 1221, 691196, 2, 33 jsou palindromy. Vytvořte ***Metodu*** (tedy ne celý program) `JePalyndrom`, která má jeden vstupní parametr. Metoda pak rozhodne jestli parametr obsahuje palindrom a pomocí návratové hodnoty o tom program informuje.

#### Příklad volání metody v jazyce C#:
```csharp
int cislo = 919;
if (JePalindrom(cislo))
    Console.WriteLine("Je to palindrom");
else
    Console.WriteLine("Neni to palindrom");
```
#### Očekávaný výstup:
```
Je to palindrom
```

### <span style="color:gold"> 8. Počítání slov </span>
Vytvořte metodu *SpoctiSlova* s následujícím rozhraním: <br>
`SpoctiSlova (text) -> Číslo` (Viz [vysvětlivka](#vysvětlivka-pro-definici-rozhraní-metod)) <br>
Tato metoda spočte kolik slov se nachází v daném textu. Slovo je definované jako posloupnost znaků (ne mezer) oddělených jednou a více mezerami nebo jedním a více odřádkováním. Například následující text obsahuje právě 12 slov.
```
Ahoj Davide,
chci ti      rict ze mam rad programovani.

S pozdravem
David
```

#### Příklad volání metody v jazyce C#:
```csharp
string text = "Why java programmers wear glasses? Beacuse they can't C#";
Console.WriteLine(SpoctiSlova(text));
```
#### Očekávaný výstup:
```
9
```

### 8.2. Počítání slov pro hnidopichy
Vytvořte metodu *SpoctiSlova* s následujícím rozhraním: <br>
`SpoctiSlova (text) -> Číslo` (Viz [vysvětlivka](#vysvětlivka-pro-definici-rozhraní-metod)) <br>
Tato metoda spočte kolik slov se nachází v daném textu. Slova jsou definovaná následovně:
 - Slovo je jakkoliv dlouhá posloupnost malých a velkých písmen anglické abecedy, čísel a podtržítek (`_`). Například text `David_je_SUPER_123` je programem bráno jako jedno slovo.
 - Každé slovo je vždy odděleno jedním nebo více znaky, které nepatří do výše definované kategorie. Napěíklad text `ahoj, davide_123.Jak se Mas?` obsahuje 5 slov.

#### Příklad volání metody v jazyce C#:
```csharp
string text1 = "Mam rad programovani";
Console.WriteLine(SpoctiSlova(text1));
string text2 = "? NechaPu, kdo_by.Takhle     psal -- achjo??";
Console.WriteLine(SpoctiSlova(text2));
```
#### Očekávaný výstup:
```
3
5
```

### 9. Počítačka palindromů
Vytvořte ***Metodu*** SpoctiPalindromy s následujícím rozhraním: <br>
`SpoctiPalindromy (text) -> Číslo` (Viz [vysvětlivka](#vysvětlivka-pro-definici-rozhraní-metod)) <br>
Tato metoda spočte kolik palindromů se nachází v zadaném textu a výsledek vrátí. <br>
> #### Při hledání palindromů počítejte s následujícím:
> - Platný palindrom obsahuje pouze čísla
> - Každé slovo i číslo v textu je odděleno alespoň jednou mezerou (na konci a začátku textu se ale žádný znak nacházet nemusí)
> - Pokud text obsahuje vícekrát ten stejný palindrom, každý z nich se počítá. Tedy text `121 121` obsahuje 2 palindromy.

#### Příklad volání metody v jazyce C#:
```csharp
string text = "Mam rad cisla 1 55 a 89 ale nemam rad cislo 1221";
Console.WriteLine(SpoctiPalindromy(text));
```
#### Očekávaný výstup:
```
3
```
