791 мс
## Результаты замера Debug vs Release 
| Режим   | Запуск 1 | Запуск 2 | Запуск 3 | Запуск 4 | Запуск 5 | Минимум |
| ------- | -------: | -------: | -------: | -------: | -------: | ------: |
| Debug   | 1961 мс | 1939 мс | 2033 мс | 1940 мс | 1982 мс | 1939 мс |
| Release | 604 мс | 542 мс | 537 мс | 537 мс | 540 мс | 537 мс |
В моём эксперименте Release оказался быстрее Debug примерно в 4 раза.

## Что я обнаружил при сравнении IL
Описание в Debug:

    // Method begins at RVA 0x2144
	// Header size: 12
	// Code size: 11 (0xb)
	.maxstack 2
Описание в Release:

	// Method begins at RVA 0x2135
	// Header size: 1
	// Code size: 4 (0x4)
	.maxstack 8
* В Debug есть строка входных и выходных данных.
* Список программ значительно отличается.

В Debug:

	IL_0000: nop
	IL_0001: ldarg.0
	IL_0002: ldarg.1
	IL_0003: add
	IL_0004: stloc.0
	IL_0005: ldloc.0
	IL_0006: stloc.1
	IL_0007: br.s IL_0009
	IL_0009: ldloc.1
	IL_000a: ret
В Release:

	IL_0000: ldarg.0
	IL_0001: ldarg.1
	IL_0002: add
	IL_0003: ret