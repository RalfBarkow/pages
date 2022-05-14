{
  "title": "Cake",
  "story": [
    {
      "type": "paragraph",
      "id": "b8934f714e38e31f",
      "text": "The Cake Linking Language [https://www.humprog.org/~stephen/research/cake/ page]"
    },
    {
      "type": "markdown",
      "id": "b682b734ebae8343",
      "text": "Cake is a linking language I'm working on as part of [[Stephen Kell]]'s PhD. Simply put, Cake provides a high-level declarative notation for gluing together interfaces which are abstractly similar but concretely different. These concrete differences might be because of simple interface evolution (i.e. gluing together components respectively providing and requiring mismatched versions of the same interface) or unanticipated composition (i.e. gluing together components with no preexisting relationship or shared origins, but providing logically compatible functionality).\n\nCake has the following novel and/or interesting properties.\n"
    },
    {
      "type": "markdown",
      "id": "d1e01f5fe50b42bb",
      "text": "* Cake is practical. The design of Cake is grounded in case studies arising from real development needs.\n* Cake targets binaries, in the form of relocatable object code. In contrast to glue coding approaches, you don't need to bother creating a build environment that can compile against the interfaces you're gluing. Provided you understand what the components are doing, you don't need source code. It really helps to have debugging information though.\n* Cake is language-agnostic, in that it is useful for any components that are in the form of relocatable object code. The current implementation is tuned to components written in C, but broadening this is a goal for future development.\n* Cake is based on the high-level abstraction of relations. These describe what values correspond between components being glued, and in what contexts. By introducing context-dependent specialisations, arbitrarily complex glue logic can be described. However, for now Cake is limited to only a few forms of context-dependency.\n* Cake is adoptable. There are no special constraints on the components which will work with Cake, so you can take your existing code and start using Cake to glue it together. It also integrates neatly into existing build systems---the Cake compiler generates a POSIX makefile designed to be included in a toplevel makefile (although it can also be invoked directly).\n* The implementation of Cake has interesting overlaps with dynamic languages, garbage collectors, debuggers, dynamic software update systems and more.\n\n\n"
    },
    {
      "type": "markdown",
      "id": "943700cabbf124e0",
      "text": "Please read the OOPSLA 2010 paper [https://www.humprog.org/~stephen/research/papers/kell10component.pdf pdf] to find out more about the language. There is also an earlier short paper from ICSE  '09 detailing some earlier case studies which shaped the design of Cake. My PhD thesis is the most complete account, but is overkill for introductory purposes. Feel free to contact me to find out more.\n\nCake has not advanced to a state where it's ready for public consumption, but adventurous users can try out what currently exists. The best reference for that is my Cake repository on GitHub.\n\nPlease do send me e-mail if you run into problems, or have general questions or comments.\n\nContent updated at Tue 2 Jun 15:00:00 BST 2015.\n"
    }
  ],
  "journal": [
    {
      "type": "create",
      "item": {
        "title": "Cake",
        "story": []
      },
      "date": 1643174147452
    },
    {
      "item": {
        "type": "factory",
        "id": "b8934f714e38e31f"
      },
      "id": "b8934f714e38e31f",
      "type": "add",
      "date": 1643174167063
    },
    {
      "type": "edit",
      "id": "b8934f714e38e31f",
      "item": {
        "type": "paragraph",
        "id": "b8934f714e38e31f",
        "text": "The Cake Linking Language"
      },
      "date": 1643174172644
    },
    {
      "item": {
        "type": "factory",
        "id": "b682b734ebae8343"
      },
      "id": "b682b734ebae8343",
      "type": "add",
      "after": "b8934f714e38e31f",
      "date": 1643174179642
    },
    {
      "type": "edit",
      "id": "b682b734ebae8343",
      "item": {
        "type": "markdown",
        "id": "b682b734ebae8343",
        "text": "Cake is a linking language I'm working on as part of my PhD. Simply put, Cake provides a high-level declarative notation for gluing together interfaces which are abstractly similar but concretely different. These concrete differences might be because of simple interface evolution (i.e. gluing together components respectively providing and requiring mismatched versions of the same interface) or unanticipated composition (i.e. gluing together components with no preexisting relationship or shared origins, but providing logically compatible functionality).\n\nCake has the following novel and/or interesting properties.\n\n    Cake is practical. The design of Cake is grounded in case studies arising from real development needs.\n    Cake targets binaries, in the form of relocatable object code. In contrast to glue coding approaches, you don't need to bother creating a build environment that can compile against the interfaces you're gluing. Provided you understand what the components are doing, you don't need source code. It really helps to have debugging information though.\n    Cake is language-agnostic, in that it is useful for any components that are in the form of relocatable object code. The current implementation is tuned to components written in C, but broadening this is a goal for future development.\n    Cake is based on the high-level abstraction of relations. These describe what values correspond between components being glued, and in what contexts. By introducing context-dependent specialisations, arbitrarily complex glue logic can be described. However, for now Cake is limited to only a few forms of context-dependency.\n    Cake is adoptable. There are no special constraints on the components which will work with Cake, so you can take your existing code and start using Cake to glue it together. It also integrates neatly into existing build systems---the Cake compiler generates a POSIX makefile designed to be included in a toplevel makefile (although it can also be invoked directly).\n    The implementation of Cake has interesting overlaps with dynamic languages, garbage collectors, debuggers, dynamic software update systems and more.\n\nPlease read the OOPSLA 2010 paper to find out more about the language. There is also an earlier short paper from ICSE  '09 detailing some earlier case studies which shaped the design of Cake. My PhD thesis is the most complete account, but is overkill for introductory purposes. Feel free to contact me to find out more.\n\nCake has not advanced to a state where it's ready for public consumption, but adventurous users can try out what currently exists. The best reference for that is my Cake repository on GitHub.\n\nPlease do send me e-mail if you run into problems, or have general questions or comments.\n\nContent updated at Tue 2 Jun 15:00:00 BST 2015.\nvalidate this page "
      },
      "date": 1643174183983
    },
    {
      "type": "edit",
      "id": "b682b734ebae8343",
      "item": {
        "type": "markdown",
        "id": "b682b734ebae8343",
        "text": "Cake is a linking language I'm working on as part of my PhD. Simply put, Cake provides a high-level declarative notation for gluing together interfaces which are abstractly similar but concretely different. These concrete differences might be because of simple interface evolution (i.e. gluing together components respectively providing and requiring mismatched versions of the same interface) or unanticipated composition (i.e. gluing together components with no preexisting relationship or shared origins, but providing logically compatible functionality).\n\nCake has the following novel and/or interesting properties.\n"
      },
      "date": 1643174191691
    },
    {
      "type": "add",
      "id": "d1e01f5fe50b42bb",
      "item": {
        "type": "markdown",
        "id": "d1e01f5fe50b42bb",
        "text": "* Cake is practical. The design of Cake is grounded in case studies arising from real development needs.\n* Cake targets binaries, in the form of relocatable object code. In contrast to glue coding approaches, you don't need to bother creating a build environment that can compile against the interfaces you're gluing. Provided you understand what the components are doing, you don't need source code. It really helps to have debugging information though.\n    Cake is language-agnostic, in that it is useful for any components that are in the form of relocatable object code. The current implementation is tuned to components written in C, but broadening this is a goal for future development.\n    Cake is based on the high-level abstraction of relations. These describe what values correspond between components being glued, and in what contexts. By introducing context-dependent specialisations, arbitrarily complex glue logic can be described. However, for now Cake is limited to only a few forms of context-dependency.\n    Cake is adoptable. There are no special constraints on the components which will work with Cake, so you can take your existing code and start using Cake to glue it together. It also integrates neatly into existing build systems---the Cake compiler generates a POSIX makefile designed to be included in a toplevel makefile (although it can also be invoked directly).\n    The implementation of Cake has interesting overlaps with dynamic languages, garbage collectors, debuggers, dynamic software update systems and more.\n\n\n"
      },
      "after": "b682b734ebae8343",
      "date": 1643174221589
    },
    {
      "type": "add",
      "id": "943700cabbf124e0",
      "item": {
        "type": "markdown",
        "id": "943700cabbf124e0",
        "text": "Please read the OOPSLA 2010 paper to find out more about the language. There is also an earlier short paper from ICSE  '09 detailing some earlier case studies which shaped the design of Cake. My PhD thesis is the most complete account, but is overkill for introductory purposes. Feel free to contact me to find out more.\n\nCake has not advanced to a state where it's ready for public consumption, but adventurous users can try out what currently exists. The best reference for that is my Cake repository on GitHub.\n\nPlease do send me e-mail if you run into problems, or have general questions or comments.\n\nContent updated at Tue 2 Jun 15:00:00 BST 2015.\nvalidate this page "
      },
      "after": "d1e01f5fe50b42bb",
      "date": 1643174223659
    },
    {
      "type": "edit",
      "id": "d1e01f5fe50b42bb",
      "item": {
        "type": "markdown",
        "id": "d1e01f5fe50b42bb",
        "text": "* Cake is practical. The design of Cake is grounded in case studies arising from real development needs.\n* Cake targets binaries, in the form of relocatable object code. In contrast to glue coding approaches, you don't need to bother creating a build environment that can compile against the interfaces you're gluing. Provided you understand what the components are doing, you don't need source code. It really helps to have debugging information though.\n* Cake is language-agnostic, in that it is useful for any components that are in the form of relocatable object code. The current implementation is tuned to components written in C, but broadening this is a goal for future development.\n* Cake is based on the high-level abstraction of relations. These describe what values correspond between components being glued, and in what contexts. By introducing context-dependent specialisations, arbitrarily complex glue logic can be described. However, for now Cake is limited to only a few forms of context-dependency.\n* Cake is adoptable. There are no special constraints on the components which will work with Cake, so you can take your existing code and start using Cake to glue it together. It also integrates neatly into existing build systems---the Cake compiler generates a POSIX makefile designed to be included in a toplevel makefile (although it can also be invoked directly).\n* The implementation of Cake has interesting overlaps with dynamic languages, garbage collectors, debuggers, dynamic software update systems and more.\n\n\n"
      },
      "date": 1643174268591
    },
    {
      "type": "edit",
      "id": "943700cabbf124e0",
      "item": {
        "type": "markdown",
        "id": "943700cabbf124e0",
        "text": "Please read the OOPSLA 2010 paper to find out more about the language. There is also an earlier short paper from ICSE  '09 detailing some earlier case studies which shaped the design of Cake. My PhD thesis is the most complete account, but is overkill for introductory purposes. Feel free to contact me to find out more.\n\nCake has not advanced to a state where it's ready for public consumption, but adventurous users can try out what currently exists. The best reference for that is my Cake repository on GitHub.\n\nPlease do send me e-mail if you run into problems, or have general questions or comments.\n\nContent updated at Tue 2 Jun 15:00:00 BST 2015.\n"
      },
      "date": 1643174277579
    },
    {
      "type": "edit",
      "id": "b8934f714e38e31f",
      "item": {
        "type": "paragraph",
        "id": "b8934f714e38e31f",
        "text": "The Cake Linking Language [https://www.humprog.org/~stephen/research/cake/ page]"
      },
      "date": 1643174294644
    },
    {
      "type": "edit",
      "id": "b682b734ebae8343",
      "item": {
        "type": "markdown",
        "id": "b682b734ebae8343",
        "text": "Cake is a linking language I'm working on as part of [[Stephen Kell]]'s PhD. Simply put, Cake provides a high-level declarative notation for gluing together interfaces which are abstractly similar but concretely different. These concrete differences might be because of simple interface evolution (i.e. gluing together components respectively providing and requiring mismatched versions of the same interface) or unanticipated composition (i.e. gluing together components with no preexisting relationship or shared origins, but providing logically compatible functionality).\n\nCake has the following novel and/or interesting properties.\n"
      },
      "date": 1643174316800
    },
    {
      "type": "edit",
      "id": "943700cabbf124e0",
      "item": {
        "type": "markdown",
        "id": "943700cabbf124e0",
        "text": "Please read the OOPSLA 2010 paper [https://www.humprog.org/~stephen/research/papers/kell10component.pdf pdf] to find out more about the language. There is also an earlier short paper from ICSE  '09 detailing some earlier case studies which shaped the design of Cake. My PhD thesis is the most complete account, but is overkill for introductory purposes. Feel free to contact me to find out more.\n\nCake has not advanced to a state where it's ready for public consumption, but adventurous users can try out what currently exists. The best reference for that is my Cake repository on GitHub.\n\nPlease do send me e-mail if you run into problems, or have general questions or comments.\n\nContent updated at Tue 2 Jun 15:00:00 BST 2015.\n"
      },
      "date": 1643174522200
    }
  ]
}