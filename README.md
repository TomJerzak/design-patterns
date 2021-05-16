# Wzorce projektowe

## Wzorce kreacyjne

Wzor­ce kre­acyj­ne są źró­dłem róż­nych me­cha­ni­zmów two­rze­nia obiek­tów, zwięk­sza­ją­cych ela­stycz­ność i uła­twia­ją­cych po­now­ne uży­cie kodu.

- Factory Method (metoda wytwórcza)  
Udo­stęp­nia in­ter­fejs do two­rze­nia obiek­tów w kla­sie ba­zo­wej, ale po­zwa­la pod­kla­som zmie­niać typ two­rzo­nych obiek­tów.

- Abs­tract Fac­to­ry (fa­bry­ka abs­trak­cyj­na)  
Umoż­li­wia two­rze­nie ro­dzin spo­krew­nio­nych ze sobą obiek­tów bez okre­śla­nia ich kon­kret­nych klas.

- Builder (bu­dow­ni­czy)  
Daje moż­li­wość kon­stru­owa­nia zło­żo­nych obiek­tów krok po kroku. Wzo­rzec ten po­zwa­la pro­du­ko­wać różne typy oraz re­pre­zen­ta­cje obiek­tu uży­wa­jąc tego sa­me­go kodu kon­struk­cyj­ne­go.

- Prototype (prototyp)  
Umożliwia kopiowanie istniejących obiektów bez tworzenia zależności pomiędzy twoim kodem, a ich klasami.

- Sin­gle­ton (sin­gle­ton)  
Po­zwa­la za­cho­wać pew­ność, że ist­nie­je wy­łącz­nie jedna in­stan­cja danej klasy oraz ist­nie­je do­stęp do niej w prze­strze­ni glo­bal­nej.

## Wzorce strukturalne

Wzor­ce struk­tu­ral­ne wy­ja­śnia­ją w jaki spo­sób można skła­dać obiek­ty i klasy w więk­sze struk­tu­ry za­cho­wu­jąc przy tym ela­stycz­ność i efek­tyw­ność tych struktur.

- Adapter (adapter)  
Pozwala na współdziałanie obiektów o niekompatybilnych interfejsach.

- Bridge (most)  
Pozwala podzielić dużą klasę lub blisko spokrewnione ze sobą klasy na dwie hierarchie: abstrakcję oraz implementację, nad którymi można pracować niezależnie od siebie.

- Composite (kompozyt)  
Pozwala komponować obiekty w struktury drzewiaste, a potem traktować je tak, jakby były one osobnymi obiektami.

- Decorator (dekorator)  
Pozwala nadawać dodatkowe obowiązki obiektom poprzez umieszczenie tych obiektów w specjalnych obiektach opakowujących, które zawierają odpowiednie zachowania.

- Facade (fasada)  
Wyposaża bibliotekę, framework lub inny złożony zestaw klas w uproszczony interfejs.

- Flyweight (pyłek)  
Pozwala zmieścić większą liczbę obiektów w dostępnej pamięci RAM poprzez współdzielenie elementów opisujących stan obiektu. Część opisu stanu jest wspólna dla wielu obiektów, więc nie muszą one zawierać kopii wszystkich danych.

- Proxy (pełnomocnik)  
Pozwala tworzyć zastępcę dla innego obiektu. Pełnomocnik nadzoruje dostęp do pierwotnego obiektu, pozwalając na wykonywanie jakiejś czynności przed lub po przekazaniu do niego żądania.

## Wzorce behawioralne

Wzorce behawioralne dotyczą algorytmów i rozdzielania odpowiedzialności pomiędzy obiektami.

- Chain od Resposibility (łańcuch zobowiązań)  
Pozwala przekazywać żądania według łańcucha obiektów obsługujących. Otrzymawszy żądanie, każdy z obiektów obsługująych decyduje o zrealizowaniu żądania lub przekazaniu go do swojego następnika w łańcuchu.

- Command (polecenie)  
Zmienia żądanie w samodzielny obiekt zawierający wszystkie informacje o tym żądaniu. Taka transformacja pozwala na parametryzowanie metod przy użyciu różnych żądań. Oprócz tego umożliwia opóżnianie lub kolejkowanie wykonywania żądań oraz pozwala na cofanie operacji.

- Iterator (iterator)  
Pozwala przechodzić sekwencyjnie po elementach zbioru bez konieczności eksponowania jego formy (lista, stos, drzewo, itp.).

- Mediator (mediator)  
Pozwala zredukować chaos zależności pomiędzy obiektami. Wzorzec ogranicza bezpośrednią komunikację pomiędzy obiektami i zmusza je do współpracy wyłącznie za pośrednictwem obiektu mediatora.

- Memento (pamiątka)  
Pozwala zapisywać i przywracać wcześniejszy stan obiektu bez ujawniania szczegółów jego implemtancji.

- Observer (obserwator)  
Pozwala zdefiniować mechanizm subskrypcji by powiadamiać wiele obiektów o zdarzeniach odbywających się w obserwowanym obiekcie.

- State (stan)  
Pozwala obiektowi zmienić swoje zachowanie gdy zmieni się jego wewnętrzny stan. Wygląda to tak, jakby obiekt zmienił swoją klasę.

- Strategy (strategia)  
Pozwala zdefiniować rodzinę algorytmów, umieścić je w osobnych klasach i uczynić obiekty tych klas wymienialnymi.

- Template Method (metoda szablonowa)  
Definiuje szkielet algorytmu w klasie bazowej, ale umożliwia podklasom nadpisanie poszczególnych etapów algorytmu bez konieczności zmiany jego struktury.

- Visitor (odwiedzający)  
Pozwala oddzielić algorytmy od obiektów na których pracują.
