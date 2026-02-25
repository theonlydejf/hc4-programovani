# Zadání: Slučování intervalů

## Cíl
Implementujte metodu, která spojí časové úseky (intervaly), které se překrývají nebo na sebe navazují.

Každý interval je zadaný dvěma čísly:
- začátek
- konec

Pokud se dva intervaly alespoň částečně překrývají **nebo jeden končí přesně tam, kde druhý začíná**, musí se spojit do jednoho delšího intervalu.

Úkolem metody je zpracovat vstup a vrátit výsledné intervaly tak, aby se už žádné nepřekrývaly.

---

## Vstup

Vstup je text obsahující několik řádků:

1. Na prvním řádku je celé číslo **N** — počet intervalů.
2. Následuje **N řádků**, na každém jsou dvě celá čísla:

`<zacatek> <konec>`

---

## Výstup

Metoda vrací text obsahující výsledné intervaly po sloučení.

Každý interval je na samostatném řádku ve formátu:

`<zacatek> <konec>`

Výsledné intervaly musí:
- být seřazené podle začátku od nejmenšího,
- nepřekrývat se,
- být maximálně sloučené (už nejdou dál spojit).

---

## Pravidla slučování

Intervaly se spojí, pokud:
- se překrývají  
  (např. `1 5` a `3 8` → `1 8`)
- nebo na sebe přesně navazují  
  (např. `1 3` a `3 6` → `1 6`)

---

## Příklad

### Vstup
```
4
1 3
2 6
8 10
10 12
```

### Výstup
```
1 6
8 12
```

---

## Neplatný vstup

Pokud metoda narazí na neplatný vstup (např. špatný formát nebo chybějící hodnoty),
vrátí přesně jeden řádek:

```
0 0
```

V tomto případě není nijak zaručeno další chování.

---

## Poznámky

- Počet intervalů může být i 0.
- Pořadí intervalů na vstupu není nijak uspořádané.
- Řešení by mělo fungovat efektivně i pro větší vstupy.