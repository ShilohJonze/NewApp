using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

"<h2>There once was a [adjective] porgrammer who wanted to use JavaScript to [verb] the [noun].</h2>"

var adjective = prompt('Please type an adjective');
var sentence = "<h2>There once was a " + adjective;
var verb = prompt('Please type a verb');
var noun = prompt('Please type a noun');

document.write(sentence);