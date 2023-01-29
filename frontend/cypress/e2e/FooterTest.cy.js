describe('Footer test', () => {
    it('checks if all menu items are present and readable', () => { 
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains("Volg ons op:").should("be.visible")
        cy.contains("Twitter pagina").should("be.visible")
        cy.contains("Facebook pagina").should("be.visible")
        cy.contains("Snapchat pagina").should("be.visible")
        cy.contains("Youtube pagina").should("be.visible")
        cy.contains("Instagram pagina").should("be.visible")
        cy.contains("Made by").should("be.visible")
        cy.contains("Shitshow inc").should("be.visible")
    })

    it('checks if Twitter is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        //Twitter page is not yet implemented
        cy.contains("Twitter pagina").click()
        cy.url().should('include', '/blank')
        cy.contains("404").should("be.visible")
    })

    it('checks if Facebook is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        //Facebook page is not yet implemented
        cy.contains("Facebook pagina").click()
        cy.url().should('include', '/blank')
        cy.contains("404").should("be.visible")
    })

    it('checks if Snapchat is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        //Snapchat page is not yet implemented
        cy.contains("Snapchat pagina").click()
        cy.url().should('include', '/blank')
        cy.contains("404").should("be.visible")
    })

    it('checks if Youtube is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        //Youtube page is not yet implemented
        cy.contains("Youtube pagina").click()
        cy.url().should('include', '/blank')
        cy.contains("404").should("be.visible")
    })
    
    it('checks if Instagram is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        //Instagram page is not yet implemented
        cy.contains("Instagram pagina").click()
        cy.url().should('include', '/blank')
        cy.contains("404").should("be.visible")
    })
    
    it('checks if Shitshow inc is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains("Shitshow inc").click()
        cy.url().should('include', '')
    })

    it('checks if Voorwaarden is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains("de algemene voorwaarden").click()
        cy.url().should('include', '/Voorwaarden')
    })
})