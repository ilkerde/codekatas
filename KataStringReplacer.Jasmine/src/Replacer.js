var Replacer = {
  replace: function(template) {
    var text = template;
    for (key in this.placeholders) {
      var placeholder = this.getPlaceholder(key);

      while (text.indexOf(placeholder) > -1)
        text = text.replace(placeholder, this.placeholders[key]);
    }

    while (this.containsPlaceholderToken(text)) {
      var token = this.parsePlaceholderToken(text);
      text = text.replace(text.substr(token.start - 1, token.end + 1 - token.start + 1), '');
    }

    return text;
  },

  getPlaceholder: function(key) {
    return "$" + key + "$";
  },

  containsPlaceholderToken: function(text) {
    token = this.parsePlaceholderToken(text);
    return (token.end > token.start) && (token.start > -1);
  },

  parsePlaceholderToken: function(text) {
    var tokenstart = text.indexOf('$') + 1;
    var tokenend = text.indexOf('$', tokenstart + 1);

    return {
      start: tokenstart,
      end: tokenend
    };
  },

  placeholders: {}
};
