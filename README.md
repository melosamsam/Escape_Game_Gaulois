# Choix de design 

Notre escape game ayant pour thème "Gaulois et Romains", nous avons voulu mettre en scène un romain (le joueur) enfermé dans la maison du druide Piquenix après avoir essayé d'espionner le druide pour découvrir la formule de la potion magique. Celui-ci doit résoudre deux puzzles afin de créer une potion de téléportation et rentrer dans son camp. 

Nous avons donc créé un camp romain inspiré des bandes dessinées "Astérix & Obélix" avec de nombreuses tentes, dont une plus grande : celle du centurion. Le tout est entouré de tours et murs en bois. 



La salle initiale de l'escape game est une maison avec un toit en paille à l'orée de la forêt : elle aussi inspirée du monde gaulois d'Astérix. Notre druide Piquenix a beaucoup voyagé et a donc ramené beaucoup de souvenirs de ses séjours à Rome : un discobole, buste de César, ... Il n'en reste pas moins un druide et dispose de bons nombres de potions !  



Nous avons utilisé les assets gratuits de Unity Asset Store afin de réaliser notre décor et pour certains items plus simples, nous les avons réalisés nous-même, comme le menhir à l'entrée ou les plaques de marbre avec les instructions par exemple. 



Les torches allumées dans la maison et les arbres à l’extérieur contribue à l’ambiance du jeu. 



La maison est peuplée d'objets, dont certains sont utiles aux puzzles. Ils se veulent tous le plus cohérent possible avec l'époque gallo-romaine. 

 

 

# Organisation des puzzles 

Cet escape game comporte deux puzzles : l’un portant sur les dieux romains, l’autre sur les potions magiques des druides. Les instructions pour les compléter sont affichées sur des plaques en marbre sur une table de la maison. 

 

Celui sur les dieux consiste à correctement placer des items associés aux dieux romains dans la mythologie, à savoir : une faucille pour Cérès, une bague/alliance pour Junon, un sceptre pour Jupiter, un poisson pour Neptune, un vase de roses pour Venus et un marteau pour Vulcain.  

Dans la salle, il y a des chiffres romains allant de 1 à 6. Dans ce puzzle, le romain doit placer les items des dieux par ordre alphabétique sur ces numéros (sockets). S’il réussit, une potion rouge, ingrédient indispensable à la potion magique, apparaîtra sur la table. Pour cela, chaque socket a un script vérifiant que l’objet posé dessus est le bon. La potion rouge a un autre script s’assurant que tous les sockets ont le bon objet placé dessus avant de réactiver son renderer.  

La conception de la potion de téléportation est le dernier puzzle de la pièce. Il suffit au joueur de résoudre l’énigme marquée dessus pour savoir quel mélange de potions servira à fuir la pièce.  

Les différentes potions sont disposées dans la pièce, et le joueur est libre de les ramasser et les poser dans le chaudron pour les mélanger. Assembler la bonne combinaison (que je ne vais pas mentionner pour ne pas “spoil” 😉) fait apparaître la potion de téléportation (potion bleue), la mauvaise combinaison réinitialise la position des potions utilisées pour un nouvel essai. 

Boire la potion bleue permet de se téléporter en dehors de la pièce, ce qui signifie une victoire pour le joueur. 
