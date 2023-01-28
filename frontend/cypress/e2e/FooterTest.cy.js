describe('template spec', () => {
    it('checks if all menu items are present and readable', () => { 
        //cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.visit ('http://localhost:3000/')
        cy.contains("Volg ons op:").should("be.visible")
        cy.contains("Twitter pagina").should("be.hidden")
        cy.contains("Facebook pagina").should("be.hidden")
        cy.contains("Snapchat pagina").should("be.hidden")
        cy.contains("Youtube pagina").should("be.hidden")
        cy.contains("Instagram pagina").should("be.hidden")
        cy.contains("Made by").should("be.visible")
        cy.contains("Shitshow inc").should("be.visible")
    })
})