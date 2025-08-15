# Programacion-Multimedia-I DIAGNOSTICO
para el diagnostico lo que realice fue lo siguiento
1 busque algoritmos en google y con ayuda de IA
2 Tanto un foro de Reddit dedicado a programacion como la IA mencionaron las cribas
3 Una rapida busqueda de cada una me dejo en claro que hay 2 buenas opciones la de Eratostenes y la segmentada
4 Para contrastar rapidamente la informacion le pide a la IA que entre esas 2 me diga cual seria la mejor para usar
4.1 Teniendo en cuenta paraemtros como cantidad de terminos y la extension de los limites
4.2 Se llego a la conclusion de usar la criba segmentada ya que puede llegar a ofrecer un mejor rendimiento si se parametriza bien el codigo
5 En una combinacion de busqueda de StackOverflow y una peticion a la IA obtuve el codigo subido
6 Lo que hace es simple (aunq a simple vista no parezca)
6.1 la criba segmentada es una forma extendida de la Eratostenes, permite trabajar con rangos mas grandes y sin la necesidad de guardar todo en un array hasta un valor n
6.2 Trabaja por bloques o segmentos marcando los multiplos por bloque
6.3 el codigo soporta un rango de hasta 5 x 10^8
6.4 el codigo primero genera los primos por la criba normal hasta la raiz 2 de limite maximo
6.5 se procesan los segmentos con low como inicio y high como final y calcula el primer multiplo p dentro de un segmento
6.5.1 marca como NO primos a los multiplos de p que estan entre low y high
6.6 recorre cada segmento contando los true como primos PERO no guarda el numero solo el contador
6.7 La complejidad del algoritmo seria de O(N log log N) siendo igual a criba de Eratostenes pero repartida por cada bloque
6.8 el espacio teorico que ocupa es de unos 125 KB debido al limite de 50 x10^8, este crece segun se aumenta
