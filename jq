{
  "title": "jq",
  "story": [
    {
      "type": "markdown",
      "id": "3d6556401886cdf5",
      "text": "https://stedolan.github.io/jq/"
    },
    {
      "type": "markdown",
      "id": "8d6718551c4923f8",
      "text": "> jq is a lightweight and flexible command-line [[JSON]] processor.\n"
    },
    {
      "type": "markdown",
      "id": "3ce9578e2e146a9e",
      "text": "# Name\njq - Command-line JSON processor\n# SYNOPSIS\njq [options...] filter [files...]\n\njq  can  transform JSON in various ways, by selecting, iterating, reducing and otherwise mangling JSON documents.\n\nFor instance, running the command jq 'map(.price) | add' will take an array of JSON objects as input  and  return the sum of their \"price\" fields.\n\njq can accept text input as well, but by default, jq reads a stream of JSON entities (including numbers and other literals) from stdin. Whitespace is only needed to separate entities such as 1 and 2, and true and false. One  or more files may be specified, in which case jq will read input from those instead.\n\nThe options are described in the INVOKING JQ section; they mostly concern input and output formatting. The filter is written in the jq language and specifies how to transform the input file or document."
    }
  ],
  "journal": [
    {
      "type": "create",
      "item": {
        "title": "jq",
        "story": []
      },
      "date": 1626528739252
    },
    {
      "item": {
        "type": "factory",
        "id": "3d6556401886cdf5"
      },
      "id": "3d6556401886cdf5",
      "type": "add",
      "date": 1626528740478
    },
    {
      "type": "edit",
      "id": "3d6556401886cdf5",
      "item": {
        "type": "markdown",
        "id": "3d6556401886cdf5",
        "text": "https://stedolan.github.io/jq/"
      },
      "date": 1626528743472
    },
    {
      "item": {
        "type": "factory",
        "id": "8d6718551c4923f8"
      },
      "id": "8d6718551c4923f8",
      "type": "add",
      "after": "3d6556401886cdf5",
      "date": 1626528752629
    },
    {
      "type": "edit",
      "id": "8d6718551c4923f8",
      "item": {
        "type": "markdown",
        "id": "8d6718551c4923f8",
        "text": "> jq is a lightweight and flexible command-line [[JSON]] processor."
      },
      "date": 1626528766363
    },
    {
      "type": "edit",
      "id": "8d6718551c4923f8",
      "item": {
        "type": "markdown",
        "id": "8d6718551c4923f8",
        "text": "> jq is a lightweight and flexible command-line [[JSON]] processor.\n"
      },
      "date": 1626529134498
    },
    {
      "type": "add",
      "id": "3ce9578e2e146a9e",
      "item": {
        "type": "markdown",
        "id": "3ce9578e2e146a9e",
        "text": "# Name\n"
      },
      "after": "8d6718551c4923f8",
      "date": 1626529141735
    },
    {
      "type": "edit",
      "id": "3ce9578e2e146a9e",
      "item": {
        "type": "markdown",
        "id": "3ce9578e2e146a9e",
        "text": "# Name\njq - Command-line JSON processor"
      },
      "date": 1626529149009
    },
    {
      "type": "edit",
      "id": "3ce9578e2e146a9e",
      "item": {
        "type": "markdown",
        "id": "3ce9578e2e146a9e",
        "text": "# Name\njq - Command-line JSON processor\n# SYNOPSIS"
      },
      "date": 1626529160704
    },
    {
      "type": "edit",
      "id": "3ce9578e2e146a9e",
      "item": {
        "type": "markdown",
        "id": "3ce9578e2e146a9e",
        "text": "# Name\njq - Command-line JSON processor\n# SYNOPSIS\njq [options...] filter [files...]\n\n       jq  can  transform JSON in various ways, by selecting, iterating, reducing and otherwise mangling JSON documents.\n       For instance, running the command jq 'map(.price) | add' will take an array of JSON objects as input  and  return\n       the sum of their \"price\" fields.\n\n       jq can accept text input as well, but by default, jq reads a stream of JSON entities (including numbers and other\n       literals) from stdin. Whitespace is only needed to separate entities such as 1 and 2, and true and false. One  or\n       more files may be specified, in which case jq will read input from those instead.\n\n       The options are described in the INVOKING JQ section; they mostly concern input and output formatting. The filter\n       is written in the jq language and specifies how to transform the input file or document."
      },
      "date": 1626529168941
    },
    {
      "type": "edit",
      "id": "3ce9578e2e146a9e",
      "item": {
        "type": "markdown",
        "id": "3ce9578e2e146a9e",
        "text": "# Name\njq - Command-line JSON processor\n# SYNOPSIS\njq [options...] filter [files...]\n\njq  can  transform JSON in various ways, by selecting, iterating, reducing and otherwise mangling JSON documents.\n\nFor instance, running the command jq 'map(.price) | add' will take an array of JSON objects as input  and  return the sum of their \"price\" fields.\n\njq can accept text input as well, but by default, jq reads a stream of JSON entities (including numbers and other literals) from stdin. Whitespace is only needed to separate entities such as 1 and 2, and true and false. One  or more files may be specified, in which case jq will read input from those instead.\n\nThe options are described in the INVOKING JQ section; they mostly concern input and output formatting. The filter is written in the jq language and specifies how to transform the input file or document."
      },
      "date": 1626529219963
    }
  ]
}