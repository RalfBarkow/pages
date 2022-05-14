{
  "title": "Pascal",
  "story": [
    {
      "type": "paragraph",
      "id": "b6f508aaa74a79ad",
      "text": "I came to know Pascal in college after I had learned how to write a compiler. I read the source for Wirth's self-hosted CDC 6000 compiler early on and was struck by its simplicity and expert use of language features to express a full-featured software tool."
    },
    {
      "type": "paragraph",
      "id": "193af9d464502e54",
      "text": "Purdue's home-brew operating system was enough different from Wirth's that the post-mortem variable dumps wouldn't print. I fixed that. I especially liked that only live variables would print, there wouldn't be many, and they would be formatted based on available type information."
    },
    {
      "type": "paragraph",
      "id": "e8f93e726af3ae70",
      "text": "Pascal's quirky type checking made it hard to pass around an array of strings but easy to construct a tree of characters. I became good a wielding such structures."
    },
    {
      "type": "paragraph",
      "id": "64d18ef86d2427cb",
      "text": "Pascal at that time allocated sequentially from a single free space and could dangerously reset the free space pointer. This worked amazingly well when synchronized with hierarchically organized dynamic behavior such as that of the compiler itself."
    },
    {
      "type": "paragraph",
      "id": "39e3f334faea34f6",
      "text": "I wrote a translator for an integrated circuit description language with scope rules (inconveniently) inspired by Pascal. The CAD group at Tektronix was having trouble writing a yacc grammar for the language. I was asked to consult. I fixed the grammar and wrote a runtime in C that modeled the same use of trees that had become my norm in Pascal. The translation inverted the relationship of nodes to elements which meant the whole structured description had to be memory resident. I defined a struct that was essentially a cons cell and ran the whole translation without freeing any dynamic allocation."
    },
    {
      "type": "paragraph",
      "id": "a023e99ec2aed270",
      "text": "My first home computer with a disk drive ran the UCSD p-code implementation of Pascal. I developed a style of coding with deeply nested definitions such that all function bodies would show cleanly on the machine's 24 x 80 character display. I wrote a grading calculator/database for my wife who was teaching undergraduate computer science at the time."
    }
  ],
  "journal": [
    {
      "type": "create",
      "item": {
        "title": "Pascal",
        "story": []
      },
      "date": 1436191967651
    },
    {
      "item": {
        "type": "factory",
        "id": "b6f508aaa74a79ad"
      },
      "id": "b6f508aaa74a79ad",
      "type": "add",
      "date": 1436191974515
    },
    {
      "type": "edit",
      "id": "b6f508aaa74a79ad",
      "item": {
        "type": "paragraph",
        "id": "b6f508aaa74a79ad",
        "text": "I came to know Pascal in college after I had learned how to write a compiler. I read Wirth"
      },
      "date": 1436192096035
    },
    {
      "type": "edit",
      "id": "b6f508aaa74a79ad",
      "item": {
        "type": "paragraph",
        "id": "b6f508aaa74a79ad",
        "text": "I came to know Pascal in college after I had learned how to write a compiler. I read the source for Wirth's self-hosted CDC 6000 compiler early on and was struck by its simplicity and expert use of language features to express a full-featured software tool."
      },
      "date": 1436192378258
    },
    {
      "type": "add",
      "id": "193af9d464502e54",
      "item": {
        "type": "paragraph",
        "id": "193af9d464502e54",
        "text": "Purdue's home-brew operating system was enough different from Wirth's that the post-mortem variable dumps wouldn't print. I fixed that. I especially liked that only live variables would print, there wouldn't be many, and they would be formatted based on available type information."
      },
      "after": "b6f508aaa74a79ad",
      "date": 1436192593420
    },
    {
      "type": "add",
      "id": "e8f93e726af3ae70",
      "item": {
        "type": "paragraph",
        "id": "e8f93e726af3ae70",
        "text": "Pascal's quirky type checking made it hard to pass around an array of strings but easy to construct a tree of characters. I became good a wielding such structures."
      },
      "after": "193af9d464502e54",
      "date": 1436192707839
    },
    {
      "type": "add",
      "id": "64d18ef86d2427cb",
      "item": {
        "type": "paragraph",
        "id": "64d18ef86d2427cb",
        "text": "Pascal at that time allocated sequentially from a single free space and could dangerously reset the free space pointer. This worked amazingly well when synchronized with hierarchically organized dynamic behavior such as that of the compiler itself."
      },
      "after": "e8f93e726af3ae70",
      "date": 1436192874872
    },
    {
      "type": "add",
      "id": "a023e99ec2aed270",
      "item": {
        "type": "paragraph",
        "id": "a023e99ec2aed270",
        "text": "My first home computer with a disk drive ran the UCSD p-code implementation of Pascal. I developed a style of coding with deeply nested definitions such that all function bodies would show cleanly on the machine's 24 x 80 character display."
      },
      "after": "64d18ef86d2427cb",
      "date": 1436193087902
    },
    {
      "type": "add",
      "id": "39e3f334faea34f6",
      "item": {
        "type": "paragraph",
        "id": "39e3f334faea34f6",
        "text": "I wrote a translator for an integrated circuit description language with scope rules (inconveniently) inspired by Pascal. The CAD group at Tektronix was having trouble writing a yacc grammar for the language. I was asked to consult. I fixed the grammar and wrote a runtime in C that modeled the same use of trees that had become my norm in Pascal. The translation inverted the relationship of nodes to elements which meant the whole structured description had to be memory resident. I defined a struct that was essentially a cons cell and ran the whole translation without freeing any dynamic allocation."
      },
      "after": "a023e99ec2aed270",
      "date": 1436193423194
    },
    {
      "type": "move",
      "order": [
        "b6f508aaa74a79ad",
        "193af9d464502e54",
        "e8f93e726af3ae70",
        "64d18ef86d2427cb",
        "39e3f334faea34f6",
        "a023e99ec2aed270"
      ],
      "id": "a023e99ec2aed270",
      "date": 1436193452977
    },
    {
      "type": "edit",
      "id": "a023e99ec2aed270",
      "item": {
        "type": "paragraph",
        "id": "a023e99ec2aed270",
        "text": "My first home computer with a disk drive ran the UCSD p-code implementation of Pascal. I developed a style of coding with deeply nested definitions such that all function bodies would show cleanly on the machine's 24 x 80 character display. I wrote a grading calculator/database for my wife who was teaching undergraduate computer science at the time."
      },
      "date": 1436193561577
    },
    {
      "type": "fork",
      "site": "code.fed.wiki.org",
      "date": 1627475084726
    }
  ]
}