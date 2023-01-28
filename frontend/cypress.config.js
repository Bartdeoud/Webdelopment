const { defineConfig } = require("cypress");

module.exports = defineConfig({
  projectId: 'ohio9k',
  e2e: {
    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});
