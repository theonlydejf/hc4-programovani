# 🌳 Strom – hloubka uzlů

## Zadání

Dostanete zadaný strom a několik ID uzlů. Pro každý z těchto uzlů určete jeho hloubku.

Hloubka uzlu znamená počet hran na cestě od kořene k danému uzlu:

- kořen má hloubku `0`
- dítě kořene má hloubku `1`
- vnuk kořene má hloubku `2`
- atd.

Dále dostanete:

- `nodeCount` – počet uzlů stromu
- `targetCount` – počet dotazů

Každý uzel je ve vstupu uložen pod klíči:

- `node0.id`, `node0.parentId`
- `node1.id`, `node1.parentId`
- ...

Každý dotaz je ve vstupu uložen pod klíčem:

- `target0.nodeId`
- `target1.nodeId`
- ...

### Úkol

1. Načtěte všechny uzly stromu
2. Pro každý dotaz zjistěte hloubku zadaného uzlu
3. Vraťte seznam hloubek ve stejném pořadí, v jakém přišly dotazy

---

## Příklad načtení dat

```csharp
int nodeCount = input.GetInt("nodeCount");
int targetCount = input.GetInt("targetCount");

for (int i = 0; i < nodeCount; i++)
{
    int id = input.GetInt("node" + i + ".id");
    int parentId = input.GetInt("node" + i + ".parentId");
}

for (int i = 0; i < targetCount; i++)
{
    int targetNodeId = input.GetInt("target" + i + ".nodeId");
}
```

---

## Výstup

Výstupem bude seznam hloubek dotazovaných uzlů ve stejném pořadí, v jakém přišly dotazy.

Například:

```json
[0, 1, 2, 3]
```

v kódu to tedy bude vypadat nějak takto:

```csharp
public object Solve(TestInput input)
{
    int[] output = new int[...];

    // Logika hledani hloubky uzlu

    return output;
}
```
