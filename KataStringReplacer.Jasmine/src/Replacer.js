var Replacer = {
  replace: function(template) {
    var text = template;
    for (key in this.placeholders) {
      var placeholder = this.getPlaceholder(key);

      while (text.indexOf(placeholder) > -1)
        text = text.replace(placeholder, this.placeholders[key]);
    }

    var tokenstart = text.indexOf('$') + 1;
    var tokenend = text.indexOf('$', tokenstart + 1);
    while ((tokenstart > -1) && (tokenend > tokenstart)) {
      text = text.replace(text.substr(tokenstart - 1, tokenend + 1 - tokenstart + 1), '');

      var tokenstart = text.indexOf('$') + 1;
      var tokenend = text.indexOf('$', tokenstart + 1);
    }

    return text;
  },

  getPlaceholder: function(key) {
    return "$" + key + "$";
  },

  placeholders: {}
};
