>https://www.alura.com.br/artigos/escrever-bom-readme?gclid=CjwKCAjw3K2XBhAzEiwAmmgrAhdWTjwFwkWqgCPD1fUirfCxlg55vKTQe-IhBt579N76BufZtLUKdhoCQCQQAvD_BwE Fundamentos do <>RADME.md<>
## 📁 Apostila

**Eduardo Guedes - Balta.io**
<h1 align="center"> Fundamentos de orientação a objetos </h1>

Um paradigma é uma forma de abordar um problema.
Alan Kay, um dos pais do paradigma da orientação a objetos, formulou a chamada “analogia biológica”. Por meio dela, ele imaginou um sistema de software que funcionasse como um ser vivo. Nesse sistema, cada “célula” interagiria com outras células através do envio de mensagens com o objetivo realizar um objetivo comum. Além disso, cada célula se comportaria como uma unidade autônoma. Assim surgiu os princípios da orientação a objetos. 
Qualquer coisa é um objeto. 
Objetos realizam tarefas por meio da requisição de serviços a outros objetos. (**composto por propriedades, métodos e eventos**)
Cada objeto pertence a uma determinada classe. 
Uma classe agrupa objetos similares.
A classe é um repositório para comportamento associado ao objeto.
Classes são organizadas em hierarquias.

O paradigma da orientação a objetos visualiza um sistema de software como uma coleção de agentes interconectados chamados objetos. É pela interação 
entre objetos que uma tarefa computacional é realizada. Um objeto é um tipo de referência que armazena o endereço dos dados. 
Os métodos são as funções, as propriedades são as variáveis.

---------------------- 
## <h2 align="center"> Classes e objetos  </h2>
A classe é o molde do objeto.
Na maioria das vezes, as coisas do mundo real são muito complexas para que todas as suas características sejam representadas em uma classe. Além disso, para fins de modelagem de um sistema, somente um subconjunto de características pode ser relevante. Portanto, uma classe representa uma abstração das características relevantes do mundo real.
Operação: alguma ação que um objeto sabe realizar quando solicitado
 Mensagem: Quando se diz na terminologia de orientação a objetos que objetos de um sistema estão trocando mensagens significa que esses objetos estão enviando mensagens uns aos outros com o objetivo de realizar alguma tarefa dentro do sistema no qual eles estão inseridos. 
Estado: Corresponde ao conjunto de valores de seus atributos em um dado momento.

--------------------
## <h2 align="center"> Encapsulamento  </h2>

O mecanismo de encapsulamento é uma forma de restringir o acesso ao comportamento interno de um objeto.
O objeto remetente da mensagem não precisa conhecer a forma pela qual a operação requisitada é realizada; tudo o que importa a esse objeto remetente é obter a operação realizada, não importando como. Ou seja, o encapsulamento seria a interface do objeto.

--------
## <h2 align="center"> Abstração  </h2>

 Esconder as características que não são relevantes.
Uma abstração de algo é dependente da perspectiva (contexto) sobre a qual uma coisa é analisada: o que é importante em um contexto pode não ser importante em outro.

--------------------
## <h2 align="center"> Herança </h2>


classes semelhantes são agrupadas em uma hierarquia. Cada nível dessa hierarquia pode ser visto como um nível de abstração. Cada classe em um nível da hierarquia herda as características e o comportamento das classes às quais está associada nos níveis acima dela. Além disso, essa classe pode definir características e comportamento particulares. Dessa forma, novas classes podem ser criadas a partir do reúso da definição de outras pré existentes. 

--------------------
## <h2 align="center"> polimorfismo </h2>

O polimorfismo se refere à capacidade de duas ou mais classes de objeto responderem à mesma mensagem, cada qual de seu próprio modo.
Assim como no caso do encapsulamento, a abstração também é aplicada para obter o polimorfismo: um objeto pode enviar a mesma mensagem para objetos semelhantes, mas que implementam a sua interface de formas diferentes. O que está se abstraindo aqui são as diferentes maneiras pelas quais os objetos receptores respondem à mesma mensagem.
