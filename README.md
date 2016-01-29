# naiMorse
Aplikacja ma na celu t³umaczenie na tekst kodu Morse’a nadawanego Ÿród³em œwiat³a w kierunku kamerki. Napisana zosta³a w C# Visual Studio 2015 przy u¿yciu biblioteki OpenCV (EmguCV). 

### Zasada dzia³ania
1. S¹ dwa obrazy - statyczne t³o oraz obraz kamerki na ¿ywo <br>
2. T³o jest "zatrzymanym" obrazem z kamerki aktualizowanym automatycznie gdy zmieni siê oœwietlenie<br>
3. Obraz i t³o konwertowane s¹ na HSV<br>
4. Wybierany jest kolor bia³y na sk³adowej V (zale¿ny odcieñ od ustawionej czu³oœci) na tle oraz obrazie<br>
5. Tworzona jest ró¿nica koloru bia³ego na tle oraz na obrazie<br>
6. Wykrywane s¹ kontury na tej ró¿nicy (najwiêkszy kontur jest brany pod uwagê)<br>
7. Je¿eli kontur jest wiêkszy ni¿ okreœlona wartoœæ, zak³adamy ¿e dioda siê œwieci<br>
8. Liczony i zapisywany jest czas gdy œwieci i nie œwieci, nastêpnie zamieniany na sekwencjê krótki-d³ugi<br>
9. Kod krótki-d³ugi zamieniany jest na znaki tekstowe<br>
<br>
Tyle w skrócie...<br><br>

<hr>
Piotr Szura<br>
PJATK<br>
projekt na zaliczenie przedmiotu NAI
