describe('Header test', () => {
  	it('checks if all menu items are present and readable', () => { 
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Programma').should("be.visible")
        cy.contains('Over ons').should("be.visible")
        cy.contains('Huur').should("be.visible")
        cy.contains('Account').should("be.visible")
        cy.contains('Winkelmand').should("be.visible")
        cy.contains('Toegankelijkheid').should("be.visible")
    })

    it('checks if programma is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Programma').click()
        cy.url().should('include', '/Programma')
    })

    it('checks if over ons is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Over ons').click()
        cy.url().should('include', '/OverOns')
    })

    it('checks if huren is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Huur').click()
        cy.url().should('include', '/Huren')
    })

    it('checks if account is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.url().should('include', '/Account')
    })

    it('checks if winkelmand is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Winkelmand').click()
        cy.url().should('include', '/Winkelmand')
    })

    it('checks if toegankelijkheid is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Toegankelijkheid').click()
        cy.url().should('include', '/Accesibility')
    })

    it('checks if the logo is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Programma/')
        cy.contains('Laaktheater').click()
        cy.url().should('include', '/')
    })

    it('checks if the bestel button is clickable', () => {
        cy.visit ('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Bestel').click()
        cy.url().should('include', '/Programma')
    })
})