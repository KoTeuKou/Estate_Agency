��U S E   [ E s t a t e _ A g e n c y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ C i t y ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ C i t y ] (  
 	 [ i d _ c i t y ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ c i t y _ n a m e ]   [ v a r c h a r ] ( 2 5 5 )   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ C i t y ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ c i t y ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ C o n t r a c t _ ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ C o n t r a c t _ ] (  
 	 [ i d _ c o n t r a c t ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ i d _ r e a l t o r ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ o w n e r ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ c u s t o m e r ]   [ i n t ]   N O T   N U L L ,  
 	 [ s a l e _ o r _ r e n t ]   [ v a r c h a r ] ( 4 )   N O T   N U L L ,  
 	 [ c o n t r a c t _ d a t e ]   [ d a t e ]   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ C o n t r a c t _ ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ c o n t r a c t ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ C o t t a g e ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ C o t t a g e ] (  
 	 [ i d _ c o t t a g e ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ c o t t a g e _ n u m b e r ]   [ i n t ]   N O T   N U L L ,  
 	 [ s q u a r e _ o f _ c o t t a g e ]   [ f l o a t ]   N O T   N U L L ,  
 	 [ n u m _ o f _ f l o o r s ]   [ i n t ]   N O T   N U L L ,  
 	 [ n u m _ o f _ r o o m s ]   [ i n t ]   N O T   N U L L ,  
 	 [ p r i c e ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ s t r e e t ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ o w n e r ]   [ i n t ]   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ C o t t a g e ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ c o t t a g e ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ C o t t a g e _ c o n t r a c t ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ C o t t a g e _ c o n t r a c t ] (  
 	 [ i d _ c o n t r a c t ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ c o t t a g e ]   [ i n t ]   N O T   N U L L  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ C u s t o m e r ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ C u s t o m e r ] (  
 	 [ i d _ c u s t o m e r ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ c u s t o m e r _ n a m e ]   [ v a r c h a r ] ( 2 5 5 )   N O T   N U L L ,  
 	 [ i d _ c i t y _ o f _ r e s i d e n c e ]   [ i n t ]   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ C u s t o m e r ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ c u s t o m e r ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ F l a t ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ F l a t ] (  
 	 [ i d _ f l a t ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ f l a t _ n u m b e r ]   [ i n t ]   N O T   N U L L ,  
 	 [ f l o o r _ n u m b e r ]   [ i n t ]   N O T   N U L L ,  
 	 [ s q u a r e _ o f _ f l a t ]   [ f l o a t ]   N O T   N U L L ,  
 	 [ n u m _ o f _ r o o m s ]   [ i n t ]   N O T   N U L L ,  
 	 [ p r i c e ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ o w n e r ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ h o u s e ]   [ i n t ]   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ F l a t ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ f l a t ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ F l a t _ c o n t r a c t ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ F l a t _ c o n t r a c t ] (  
 	 [ i d _ c o n t r a c t ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ f l a t ]   [ i n t ]   N O T   N U L L  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ H o u s e ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ H o u s e ] (  
 	 [ i d _ h o u s e ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ h o u s e _ n u m ]   [ i n t ]   N O T   N U L L ,  
 	 [ n u m _ o f _ f l o o r s ]   [ i n t ]   N O T   N U L L ,  
 	 [ i d _ s t r e e t ]   [ i n t ]   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ H O U S E ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ h o u s e ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ O w n e r _ ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ O w n e r _ ] (  
 	 [ i d _ o w n e r ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ o w n e r _ n a m e ]   [ v a r c h a r ] ( 2 5 5 )   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ O w n e r _ ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ o w n e r ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ R e a l t o r ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ R e a l t o r ] (  
 	 [ i d _ r e a l t o r ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ r e a l t o r _ n a m e ]   [ v a r c h a r ] ( 2 5 5 )   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ R e a l t o r ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ r e a l t o r ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 / * * * * * *   O b j e c t :     T a b l e   [ d b o ] . [ S t r e e t ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   T A B L E   [ d b o ] . [ S t r e e t ] (  
 	 [ i d _ s t r e e t ]   [ i n t ]   I D E N T I T Y ( 1 , 1 )   N O T   N U L L ,  
 	 [ s t r e e t _ n a m e ]   [ v a r c h a r ] ( 2 5 5 )   N O T   N U L L ,  
 	 [ i d _ c i t y ]   [ i n t ]   N O T   N U L L ,  
   C O N S T R A I N T   [ P K _ S t r e e t ]   P R I M A R Y   K E Y   N O N C L U S T E R E D    
 (  
 	 [ i d _ s t r e e t ]   A S C  
 ) W I T H   ( P A D _ I N D E X   =   O F F ,   S T A T I S T I C S _ N O R E C O M P U T E   =   O F F ,   I G N O R E _ D U P _ K E Y   =   O F F ,   A L L O W _ R O W _ L O C K S   =   O N ,   A L L O W _ P A G E _ L O C K S   =   O N )   O N   [ P R I M A R Y ]  
 )   O N   [ P R I M A R Y ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o n t r a c t _ ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C o n t r a c t _ _ C u s t o m e r ]   F O R E I G N   K E Y ( [ i d _ c u s t o m e r ] )  
 R E F E R E N C E S   [ d b o ] . [ C u s t o m e r ]   ( [ i d _ c u s t o m e r ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o n t r a c t _ ]   C H E C K   C O N S T R A I N T   [ F K _ C o n t r a c t _ _ C u s t o m e r ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o n t r a c t _ ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C o n t r a c t _ _ O w n e r _ ]   F O R E I G N   K E Y ( [ i d _ o w n e r ] )  
 R E F E R E N C E S   [ d b o ] . [ O w n e r _ ]   ( [ i d _ o w n e r ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o n t r a c t _ ]   C H E C K   C O N S T R A I N T   [ F K _ C o n t r a c t _ _ O w n e r _ ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o n t r a c t _ ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C o n t r a c t _ _ R e a l t o r ]   F O R E I G N   K E Y ( [ i d _ r e a l t o r ] )  
 R E F E R E N C E S   [ d b o ] . [ R e a l t o r ]   ( [ i d _ r e a l t o r ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o n t r a c t _ ]   C H E C K   C O N S T R A I N T   [ F K _ C o n t r a c t _ _ R e a l t o r ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C o t t a g e _ O w n e r _ ]   F O R E I G N   K E Y ( [ i d _ o w n e r ] )  
 R E F E R E N C E S   [ d b o ] . [ O w n e r _ ]   ( [ i d _ o w n e r ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e ]   C H E C K   C O N S T R A I N T   [ F K _ C o t t a g e _ O w n e r _ ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C o t t a g e _ S t r e e t ]   F O R E I G N   K E Y ( [ i d _ s t r e e t ] )  
 R E F E R E N C E S   [ d b o ] . [ S t r e e t ]   ( [ i d _ s t r e e t ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e ]   C H E C K   C O N S T R A I N T   [ F K _ C o t t a g e _ S t r e e t ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e _ c o n t r a c t ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C o t t a g e _ c o n t r a c t _ C o n t r a c t _ ]   F O R E I G N   K E Y ( [ i d _ c o n t r a c t ] )  
 R E F E R E N C E S   [ d b o ] . [ C o n t r a c t _ ]   ( [ i d _ c o n t r a c t ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e _ c o n t r a c t ]   C H E C K   C O N S T R A I N T   [ F K _ C o t t a g e _ c o n t r a c t _ C o n t r a c t _ ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e _ c o n t r a c t ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C o t t a g e _ c o n t r a c t _ C o t t a g e ]   F O R E I G N   K E Y ( [ i d _ c o t t a g e ] )  
 R E F E R E N C E S   [ d b o ] . [ C o t t a g e ]   ( [ i d _ c o t t a g e ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C o t t a g e _ c o n t r a c t ]   C H E C K   C O N S T R A I N T   [ F K _ C o t t a g e _ c o n t r a c t _ C o t t a g e ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C u s t o m e r ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ C u s t o m e r _ C i t y ]   F O R E I G N   K E Y ( [ i d _ c i t y _ o f _ r e s i d e n c e ] )  
 R E F E R E N C E S   [ d b o ] . [ C i t y ]   ( [ i d _ c i t y ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ C u s t o m e r ]   C H E C K   C O N S T R A I N T   [ F K _ C u s t o m e r _ C i t y ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ F l a t _ H o u s e ]   F O R E I G N   K E Y ( [ i d _ h o u s e ] )  
 R E F E R E N C E S   [ d b o ] . [ H o u s e ]   ( [ i d _ h o u s e ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t ]   C H E C K   C O N S T R A I N T   [ F K _ F l a t _ H o u s e ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ F l a t _ O w n e r _ ]   F O R E I G N   K E Y ( [ i d _ o w n e r ] )  
 R E F E R E N C E S   [ d b o ] . [ O w n e r _ ]   ( [ i d _ o w n e r ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t ]   C H E C K   C O N S T R A I N T   [ F K _ F l a t _ O w n e r _ ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t _ c o n t r a c t ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ F l a t _ c o n t r a c t _ C o n t r a c t _ ]   F O R E I G N   K E Y ( [ i d _ c o n t r a c t ] )  
 R E F E R E N C E S   [ d b o ] . [ C o n t r a c t _ ]   ( [ i d _ c o n t r a c t ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t _ c o n t r a c t ]   C H E C K   C O N S T R A I N T   [ F K _ F l a t _ c o n t r a c t _ C o n t r a c t _ ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t _ c o n t r a c t ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ F l a t _ c o n t r a c t _ F l a t ]   F O R E I G N   K E Y ( [ i d _ f l a t ] )  
 R E F E R E N C E S   [ d b o ] . [ F l a t ]   ( [ i d _ f l a t ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ F l a t _ c o n t r a c t ]   C H E C K   C O N S T R A I N T   [ F K _ F l a t _ c o n t r a c t _ F l a t ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ H o u s e ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ H o u s e _ S t r e e t ]   F O R E I G N   K E Y ( [ i d _ s t r e e t ] )  
 R E F E R E N C E S   [ d b o ] . [ S t r e e t ]   ( [ i d _ s t r e e t ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ H o u s e ]   C H E C K   C O N S T R A I N T   [ F K _ H o u s e _ S t r e e t ]  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ S t r e e t ]     W I T H   N O C H E C K   A D D     C O N S T R A I N T   [ F K _ S t r e e t _ C i t y ]   F O R E I G N   K E Y ( [ i d _ c i t y ] )  
 R E F E R E N C E S   [ d b o ] . [ C i t y ]   ( [ i d _ c i t y ] )  
 G O  
 A L T E R   T A B L E   [ d b o ] . [ S t r e e t ]   C H E C K   C O N S T R A I N T   [ F K _ S t r e e t _ C i t y ]  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ A D D _ C O T T A G E ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
 C R E A T E   P R O C   [ d b o ] . [ A D D _ C O T T A G E ]  
 @ c o t t a g e _ n u m b e r   i n t ,   @ n u m _ o f _ f l o o r s   i n t ,   @ s q u a r e _ o f _ c o t t a g e   f l o a t ,  
 @ n u m _ o f _ r o o m s   i n t ,   @ p r i c e   i n t ,   @ i d _ o w n e r   i n t ,   @ i d _ s t r e e t   i n t  
 A S  
 	 I N S E R T   I N T O   C o t t a g e   V A L U E S ( @ c o t t a g e _ n u m b e r ,   @ n u m _ o f _ f l o o r s ,   @ s q u a r e _ o f _ c o t t a g e ,   @ n u m _ o f _ r o o m s ,   @ p r i c e ,   @ i d _ o w n e r ,   @ i d _ s t r e e t )  
 	 S E L E C T   i d _ c o t t a g e ,   c o t t a g e _ n u m b e r ,   n u m _ o f _ f l o o r s ,   s q u a r e _ o f _ c o t t a g e ,   n u m _ o f _ r o o m s ,   p r i c e ,   o w n e r _ n a m e ,   s t r e e t _ n a m e ,   c i t y _ n a m e  
         F R O M   C o t t a g e   c t g   I N N E R   J O I N   O w n e r _   o   O N   c t g . i d _ o w n e r   =   o . i d _ o w n e r    
 	 I N N E R   J O I N   S t r e e t   s t   O N   c t g . i d _ s t r e e t   =   s t . i d _ s t r e e t    
 	 I N N E R   J O I N   C i t y   c   O N   s t . i d _ c i t y   =   c . i d _ c i t y  
 	 W H E R E   c t g . i d _ c o t t a g e   =   S C O P E _ I D E N T I T Y ( )  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ A D D _ F L A T ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
 C R E A T E   P R O C   [ d b o ] . [ A D D _ F L A T ]  
 @ f l a t _ n u m b e r   i n t ,   @ f l o o r _ n u m b e r   i n t ,   @ s q u a r e _ o f _ f l a t   f l o a t ,  
 @ n u m _ o f _ r o o m s   i n t ,   @ p r i c e   i n t ,   @ i d _ o w n e r   i n t ,   @ i d _ h o u s e   i n t  
 A S  
 	 I N S E R T   I N T O   F l a t   V A L U E S ( @ f l a t _ n u m b e r ,   @ f l o o r _ n u m b e r ,   @ s q u a r e _ o f _ f l a t ,   @ n u m _ o f _ r o o m s ,   @ p r i c e ,   @ i d _ o w n e r ,   @ i d _ h o u s e )  
 	 S E L E C T   i d _ f l a t ,   f l a t _ n u m b e r ,   f l o o r _ n u m b e r ,   s q u a r e _ o f _ f l a t ,   n u m _ o f _ r o o m s ,   p r i c e ,   o w n e r _ n a m e ,   h o u s e _ n u m ,   s t r e e t _ n a m e ,   c i t y _ n a m e    
 	 F R O M   F l a t   f   I N N E R   J O I N   O w n e r _   o   O N   f . i d _ o w n e r   =   o . i d _ o w n e r  
                                 I N N E R   J O I N   H o u s e   h   O N   f . i d _ h o u s e   =   h . i d _ h o u s e  
                                 I N N E R   J O I N   S t r e e t   s t   O N   h . i d _ s t r e e t   =   s t . i d _ s t r e e t  
                                 I N N E R   J O I N   C i t y   c   O N   s t . i d _ c i t y   =   c . i d _ c i t y  
 	 W H E R E   f . i d _ f l a t   =   S C O P E _ I D E N T I T Y ( )  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ F I N D _ C O T T A G E _ B Y _ F I L T E R S ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
  
  
 C R E A T E   P R O C   [ d b o ] . [ F I N D _ C O T T A G E _ B Y _ F I L T E R S ]  
 	 @ n u m _ o f _ f l o o r s _ m i n   i n t ,   @ n u m _ o f _ f l o o r s _ m a x   i n t ,  
 	 @ s q _ m i n   f l o a t ,   @ s q _ m a x   f l o a t ,  
 	 @ n u m _ o f _ r m s _ m i n   i n t ,   @ n u m _ o f _ r m s _ m a x   i n t ,  
 	 @ p r i c e _ m i n   i n t ,   @ p r i c e _ m a x   i n t ,  
 	 @ n u m _ o f _ c o t t a g e _ m i n   i n t ,   @ n u m _ o f _ c o t t a g e _ m a x   i n t ,  
 	 @ c i t y   n v a r c h a r ,   @ s t r e e t   n v a r c h a r  
 A S  
         S E L E C T   i d _ c o t t a g e ,   c o t t a g e _ n u m b e r ,   n u m _ o f _ f l o o r s ,   s q u a r e _ o f _ c o t t a g e ,   n u m _ o f _ r o o m s ,   p r i c e ,   o w n e r _ n a m e ,   s t r e e t _ n a m e ,   c i t y _ n a m e  
         F R O M   C o t t a g e   c t g   I N N E R   J O I N   O w n e r _   o   O N   c t g . i d _ o w n e r   =   o . i d _ o w n e r    
 	 I N N E R   J O I N   S t r e e t   s t   O N   c t g . i d _ s t r e e t   =   s t . i d _ s t r e e t    
 	 I N N E R   J O I N   C i t y   c   O N   s t . i d _ c i t y   =   c . i d _ c i t y  
 	 W H E R E   c t g . i d _ s t r e e t   =   A N Y (  
 	 	 	 S E L E C T   i d _ s t r e e t   F R O M   S t r e e t   W H E R E   s t r e e t _ n a m e   L I K E   @ s t r e e t   +   ' % '   A N D   i d _ c i t y   =   A N Y (  
 	 	 	 	 S E L E C T   i d _ c i t y   F R O M   C i t y   W H E R E   c i t y _ n a m e   L I K E   @ c i t y   +   ' % ' ) )  
 	       A N D   n u m _ o f _ f l o o r s   > =   @ n u m _ o f _ f l o o r s _ m i n   A N D   n u m _ o f _ f l o o r s   < =   @ n u m _ o f _ f l o o r s _ m a x   A N D  
 	       s q u a r e _ o f _ c o t t a g e   > =   @ s q _ m i n   A N D   s q u a r e _ o f _ c o t t a g e   < =   @ s q _ m a x   A N D  
 	       n u m _ o f _ r o o m s   > =   @ n u m _ o f _ r m s _ m i n   A N D   n u m _ o f _ r o o m s   < =   @ n u m _ o f _ r m s _ m a x   A N D  
 	       c o t t a g e _ n u m b e r   > =   @ n u m _ o f _ c o t t a g e _ m i n   A N D   c o t t a g e _ n u m b e r   < =   @ n u m _ o f _ c o t t a g e _ m a x   A N D  
 	       p r i c e   > =   @ p r i c e _ m i n   A N D   p r i c e   < =   @ p r i c e _ m a x  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ F I N D _ F L A T _ B Y _ F I L T E R S ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
 C R E A T E   P R O C   [ d b o ] . [ F I N D _ F L A T _ B Y _ F I L T E R S ]  
 	 @ f l _ n u m _ m i n   i n t ,   @ f l _ n u m _ m a x   i n t ,  
 	 @ s q _ m i n   f l o a t ,   @ s q _ m a x   f l o a t ,  
 	 @ n u m _ o f _ r m s _ m i n   i n t ,   @ n u m _ o f _ r m s _ m a x   i n t ,  
 	 @ p r i c e _ m i n   i n t ,   @ p r i c e _ m a x   i n t ,  
 	 @ n u m _ o f _ h o u s e _ m i n   i n t , @ n u m _ o f _ h o u s e _ m a x   i n t ,  
 	 @ c i t y   n v a r c h a r ,   @ s t r e e t   n v a r c h a r  
 A S  
         S E L E C T   i d _ f l a t ,   f l a t _ n u m b e r ,   f l o o r _ n u m b e r ,   s q u a r e _ o f _ f l a t ,   n u m _ o f _ r o o m s ,   p r i c e ,   o w n e r _ n a m e ,   h o u s e _ n u m ,   s t r e e t _ n a m e ,   c i t y _ n a m e  
         F R O M   F l a t   f   I N N E R   J O I N   O w n e r _   o   O N   f . i d _ o w n e r   =   o . i d _ o w n e r    
 	 I N N E R   J O I N   H o u s e   h   O N   f . i d _ h o u s e   =   h . i d _ h o u s e    
 	 I N N E R   J O I N   S t r e e t   s t   O N   h . i d _ s t r e e t   =   s t . i d _ s t r e e t    
 	 I N N E R   J O I N   C i t y   c   O N   s t . i d _ c i t y   =   c . i d _ c i t y   W H E R E   f . i d _ h o u s e   =   A N Y (  
 	 	 S E L E C T   i d _ h o u s e   F R O M   H o u s e   W H E R E   h o u s e _ n u m   > =   @ n u m _ o f _ h o u s e _ m i n   A N D    
 	 	 h o u s e _ n u m   < =   @ n u m _ o f _ h o u s e _ m a x   A N D   i d _ s t r e e t   =   A N Y (  
 	 	 S E L E C T   i d _ s t r e e t   F R O M   S t r e e t   W H E R E   s t r e e t _ n a m e   L I K E   @ s t r e e t   +   ' % '   A N D   i d _ c i t y   =   A N Y (  
 	 	 	 S E L E C T   i d _ c i t y   F R O M   C i t y   W H E R E   c i t y _ n a m e   L I K E   @ c i t y   +   ' % ' ) ) )  
 	 A N D   f l o o r _ n u m b e r   > =   @ f l _ n u m _ m i n   A N D   f l o o r _ n u m b e r   < =   @ f l _ n u m _ m a x   A N D  
 	 s q u a r e _ o f _ f l a t   > =   @ s q _ m i n   A N D   s q u a r e _ o f _ f l a t   < =   @ s q _ m a x   A N D  
 	 n u m _ o f _ r o o m s   > =   @ n u m _ o f _ r m s _ m i n   A N D   n u m _ o f _ r o o m s   < =   @ n u m _ o f _ r m s _ m a x   A N D  
 	 p r i c e   > =   @ p r i c e _ m i n   A N D   p r i c e   < =   @ p r i c e _ m a x  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ G E T _ A L L _ C O T T A G E S ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
 C R E A T E   P R O C   [ d b o ] . [ G E T _ A L L _ C O T T A G E S ]  
 A S  
 	 S E L E C T   i d _ c o t t a g e ,   c o t t a g e _ n u m b e r ,   n u m _ o f _ f l o o r s ,   s q u a r e _ o f _ c o t t a g e ,   n u m _ o f _ r o o m s ,   p r i c e ,   o w n e r _ n a m e ,   s t r e e t _ n a m e ,   c i t y _ n a m e  
         F R O M   C o t t a g e   c t g   I N N E R   J O I N   O w n e r _   o   O N   c t g . i d _ o w n e r   =   o . i d _ o w n e r    
 	 I N N E R   J O I N   S t r e e t   s t   O N   c t g . i d _ s t r e e t   =   s t . i d _ s t r e e t    
 	 I N N E R   J O I N   C i t y   c   O N   s t . i d _ c i t y   =   c . i d _ c i t y  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ G E T _ A L L _ F L A T S ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
 C R E A T E   P R O C   [ d b o ] . [ G E T _ A L L _ F L A T S ]  
 A S  
 	 S E L E C T   i d _ f l a t ,   f l a t _ n u m b e r ,   f l o o r _ n u m b e r ,   s q u a r e _ o f _ f l a t ,   n u m _ o f _ r o o m s ,   p r i c e ,   o w n e r _ n a m e ,   h o u s e _ n u m ,   s t r e e t _ n a m e ,   c i t y _ n a m e    
 	 F R O M   F l a t   f   I N N E R   J O I N   O w n e r _   o   O N   f . i d _ o w n e r   =   o . i d _ o w n e r  
                                 I N N E R   J O I N   H o u s e   h   O N   f . i d _ h o u s e   =   h . i d _ h o u s e  
                                 I N N E R   J O I N   S t r e e t   s t   O N   h . i d _ s t r e e t   =   s t . i d _ s t r e e t  
                                 I N N E R   J O I N   C i t y   c   O N   s t . i d _ c i t y   =   c . i d _ c i t y  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ H O W _ M A N Y _ C O N T R A C T S ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
 C R E A T E   P R O C   [ d b o ] . [ H O W _ M A N Y _ C O N T R A C T S ]  
 @ i d _ r e a l t o r   i n t  
 A S  
 	 	 D E C L A R E   @ t i m e s   i n t  
 	 	 S E T   @ t i m e s   =   0  
 	 	 S E L E C T   t i m e s   =   C O U N T ( * )     f r o m   C o n t r a c t _   c   w h e r e   c . i d _ r e a l t o r   =   @ i d _ r e a l t o r  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ H O W _ M A N Y _ T I M E S _ R E S O L D ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
 C R E A T E   P R O C   [ d b o ] . [ H O W _ M A N Y _ T I M E S _ R E S O L D ]  
 	 @ i d _ b u i l d i n g   i n t ,   @ c o t t a g e _ o r _ f l a t   n v a r c h a r  
 A S  
 	 D E C L A R E   @ t i m e s   i n t  
 	 S E T   @ t i m e s   =   0  
 	 I F   ( @ c o t t a g e _ o r _ f l a t   =   ' C O T T A G E ' )  
 	 	   ( S E L E C T   t i m e s   =   C O U N T ( * )   F R O M   C o n t r a c t _   c   I N N E R   J O I N   C o t t a g e _ c o n t r a c t   c t  
 	 	 	   O N   c t . i d _ c o n t r a c t   =   c . i d _ c o n t r a c t   W H E R E   c t . i d _ c o t t a g e   =   @ i d _ b u i l d i n g )  
 	 E L S E  
 	 	 ( S E L E C T   t i m e s   =   C O U N T ( * )   F R O M   C o n t r a c t _   c   I N N E R   J O I N   F l a t _ c o n t r a c t   f  
 	 	 	 	   O N   f . i d _ c o n t r a c t   =   c . i d _ c o n t r a c t   W H E R E   f . i d _ f l a t   =   @ i d _ b u i l d i n g )  
 	 R E T U R N   @ t i m e s  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ R E N T _ B U I L D I N G ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
 C R E A T E   P R O C   [ d b o ] . [ R E N T _ B U I L D I N G ]  
 	 @ i d _ b u i l d i n g   i n t ,   @ i d _ r e a l t o r   i n t ,   @ c o t t a g e _ o r _ f l a t   n v a r c h a r ,   @ i d _ c u s t o m e r   i n t  
 A S    
 	 S E T   N O C O U N T   O N ;  
 	 D E C L A R E   @ i d _ c o n t r   i n t ,   @ i d _ o w n e r   i n t ;  
 	 I F   ( @ c o t t a g e _ o r _ f l a t   =   ' C O T T A G E ' )  
 	 	 S E L E C T   @ i d _ o w n e r   =   i d _ o w n e r   F R O M   C o t t a g e   W H E R E   i d _ c o t t a g e   =   @ i d _ b u i l d i n g  
 	 E L S E  
 	 	 S E L E C T   @ i d _ o w n e r   =   i d _ o w n e r   F R O M   F l a t   W H E R E   i d _ f l a t   =   @ i d _ b u i l d i n g  
 	 I N S E R T   I N T O   C o n t r a c t _  
         V A L U E S ( @ i d _ r e a l t o r ,   @ i d _ o w n e r ,   @ i d _ c u s t o m e r ,   ' R e n t ' ,   G E T D A T E ( ) )  
  
 	  
 	 S E T   @ i d _ c o n t r   =   I D E N T _ C U R R E N T   ( ' C o n t r a c t _ ' )  
 	 I F   ( @ c o t t a g e _ o r _ f l a t   =   ' C O T T A G E ' )  
 	 	 B E G I N  
 	 	 	 I N S E R T   I N T O   C o t t a g e _ c o n t r a c t  
 	 	 	 V A L U E S ( @ i d _ c o n t r ,   @ i d _ b u i l d i n g )  
 	 	 E N D  
 	 E L S E  
 	 	 B E G I N  
 	 	 	 I N S E R T   I N T O   F l a t _ c o n t r a c t  
 	 	 	 V A L U E S ( @ i d _ c o n t r ,   @ i d _ b u i l d i n g )  
 	 	 E N D  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ S E L L _ B U I L D I N G ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
  
 C R E A T E   P R O C   [ d b o ] . [ S E L L _ B U I L D I N G ]  
 	 @ i d _ b u i l d i n g   i n t ,   @ i d _ r e a l t o r   i n t ,   @ c o t t a g e _ o r _ f l a t   n v a r c h a r ,   @ i d _ c u s t o m e r   i n t  
 A S    
 	 S E T   N O C O U N T   O N ;  
 	 D E C L A R E   @ i d _ c o n t r   i n t ,   @ i d _ o w n e r   i n t ;  
 	 I F   ( @ c o t t a g e _ o r _ f l a t   =   ' C O T T A G E ' )  
 	 	 S E L E C T   @ i d _ o w n e r   =   i d _ o w n e r   F R O M   C o t t a g e   W H E R E   i d _ c o t t a g e   =   @ i d _ b u i l d i n g  
 	 E L S E  
 	 	 S E L E C T   @ i d _ o w n e r   =   i d _ o w n e r   F R O M   F l a t   W H E R E   i d _ f l a t   =   @ i d _ b u i l d i n g  
 	 I N S E R T   I N T O   C o n t r a c t _  
         V A L U E S ( @ i d _ r e a l t o r ,   @ i d _ o w n e r ,   @ i d _ c u s t o m e r ,   ' S e l l ' ,   G E T D A T E ( ) )  
  
 	  
 	 S E T   @ i d _ c o n t r   =   I D E N T _ C U R R E N T   ( ' C o n t r a c t _ ' )  
 	 I F   ( @ c o t t a g e _ o r _ f l a t   =   ' C O T T A G E ' )  
 	 	 B E G I N  
 	 	 	 I N S E R T   I N T O   C o t t a g e _ c o n t r a c t  
 	 	 	 V A L U E S ( @ i d _ c o n t r ,   @ i d _ b u i l d i n g )  
  
 	 	 	 U P D A T E   C o t t a g e    
 	 	 	 S E T   i d _ o w n e r   =   @ i d _ c u s t o m e r    
 	 	 	 W H E R E   i d _ c o t t a g e   =   @ i d _ b u i l d i n g  
 	 	 E N D  
 	 E L S E  
 	 	 B E G I N  
 	 	 	 I N S E R T   I N T O   F l a t _ c o n t r a c t  
 	 	 	 V A L U E S ( @ i d _ c o n t r ,   @ i d _ b u i l d i n g )  
  
 	 	 	 U P D A T E   F l a t    
 	 	 	 S E T   i d _ o w n e r   =   @ i d _ c u s t o m e r    
 	 	 	 W H E R E   i d _ f l a t   =   @ i d _ b u i l d i n g  
 	 	 E N D  
 G O  
 / * * * * * *   O b j e c t :     S t o r e d P r o c e d u r e   [ d b o ] . [ S H O W _ A L L _ E X P E R I E N C E D _ R E A L T O R S ]         S c r i p t   D a t e :   3 0 . 0 9 . 2 0 2 0   1 8 : 1 6 : 3 2   * * * * * * /  
 S E T   A N S I _ N U L L S   O N  
 G O  
 S E T   Q U O T E D _ I D E N T I F I E R   O N  
 G O  
  
  
  
 C R E A T E   P R O C   [ d b o ] . [ S H O W _ A L L _ E X P E R I E N C E D _ R E A L T O R S ]  
 A S  
 	 	 S E L E C T   *  
 	 	 F R O M   R e a l t o r   r  
 	 	 W H E R E   E X I S T S   ( S E L E C T   *   f r o m   C o n t r a c t _   c   w h e r e   c . i d _ r e a l t o r   =   r . i d _ r e a l t o r )  
 G O  
 