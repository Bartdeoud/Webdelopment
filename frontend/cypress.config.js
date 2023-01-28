const { defineConfig } = require("cypress");

module.exports = defineConfig({
    projectId: 'ohio9k',
    e2e: {
        video:false,
        screenshotOnRunFailure:false
    },
});
