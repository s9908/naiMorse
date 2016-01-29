# naiMorse
Aplikacja ma na celu t�umaczenie na tekst kodu Morse�a nadawanego �r�d�em �wiat�a w kierunku kamerki. Napisana zosta�a w C# Visual Studio 2015 przy u�yciu biblioteki OpenCV (EmguCV). 

### Zasada dzia�ania
1. S� dwa obrazy - statyczne t�o oraz obraz kamerki na �ywo <br>
2. T�o jest "zatrzymanym" obrazem z kamerki aktualizowanym automatycznie gdy zmieni si� o�wietlenie<br>
3. Obraz i t�o konwertowane s� na HSV<br>
4. Wybierany jest kolor bia�y na sk�adowej V (zale�ny odcie� od ustawionej czu�o�ci) na tle oraz obrazie<br>
5. Tworzona jest r�nica koloru bia�ego na tle oraz na obrazie<br>
6. Wykrywane s� kontury na tej r�nicy (najwi�kszy kontur jest brany pod uwag�)<br>
7. Je�eli kontur jest wi�kszy ni� okre�lona warto��, zak�adamy �e dioda si� �wieci<br>
8. Liczony i zapisywany jest czas gdy �wieci i nie �wieci, nast�pnie zamieniany na sekwencj� kr�tki-d�ugi<br>
9. Kod kr�tki-d�ugi zamieniany jest na znaki tekstowe<br>
<br>
Tyle w skr�cie...<br><br>

<hr>
Piotr Szura<br>
PJATK<br>
projekt na zaliczenie przedmiotu NAI
