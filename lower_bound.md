# Lower bound

## Zadani

Dostanete posloupnost operaci nad mnozinou celych cisel.

Vasim ukolem je tuto mnozinu prubezne udrzovat a pro kazdy dotaz typu **lower bound** vratit:

- nejmensi cislo v mnozine, ktere je **vetsi nebo rovno** zadane hodnote
- pokud takove cislo neexistuje, vratte `null`

---

## Vstup

Na vstupu dostanete:

- `opCount` - pocet operaci
- pro kazdou operaci:
  - `op0.type`, `op0.value`
  - `op1.type`, `op1.value`
  - ...

### Vyznam `type`

- `0` = `insert`
- `1` = `lowerBound`

### Vyznam operaci

#### `insert`

Pridejte zadanou hodnotu do mnoziny.

- pokud uz v mnozine je, nic se nemeni

#### `lowerBound`

Najdete nejmensi ulozenou hodnotu, ktera je `>= opX.value`.

- pokud zadna takova hodnota neexistuje, vratte `null`

---

## Co je potreba udelat

1. Zpracujte operace v presnem poradi, v jakem prisly
2. Udrzujte aktualni stav mnoziny
3. Pro kazdou operaci `lowerBound` ulozte odpoved do vystupu
4. Vratte pole odpovedi ve stejnem poradi, v jakem prisly dotazy

---

## Priklad nacteni dat

```csharp
int opCount = input.GetInt("opCount");

for (int i = 0; i < opCount; i++)
{
    int type = input.GetInt("op" + i + ".type");
    int value = input.GetInt("op" + i + ".value");
}
```

---

## Priklad vstupu

```json
{
  "opCount": 7,

  "op0.type": 0,
  "op0.value": 10,

  "op1.type": 1,
  "op1.value": 5,

  "op2.type": 0,
  "op2.value": 4,

  "op3.type": 1,
  "op3.value": 4,

  "op4.type": 1,
  "op4.value": 6,

  "op5.type": 0,
  "op5.value": 20,

  "op6.type": 1,
  "op6.value": 21
}
```

---

## Priklad vystupu

```json
[10, 4, 10, null]
```

---

## Poznamky

- vstupni hodnoty jsou vzdy platna `int`
- operace `insert` se chova jako vlozeni do mnoziny, ne do seznamu
- u velkych testu je dulezita efektivita vkladani i hledani
- na malych testech projde i jednoduche reseni, ale velke testy jsou navrzene pro rychle vyhledavani

---

## Naznak vystupu v kodu

```csharp
public object Solve(TestInput input)
{
    List<int?> output = new List<int?>();

    // logika insert a lowerBound

    return output;
}
```
