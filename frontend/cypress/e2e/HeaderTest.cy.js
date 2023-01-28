describe('Check page switching', () => {
  	it('checks if all menu items are present and readable', () => { 
        cy.visit ('http://localhost:3000/')
        cy.contains('Menu').click()
        cy.contains('Programma')
        cy.contains('Over ons')
        cy.contains('Huur')
        cy.contains('Account')
        cy.contains('Winkelmand')
        cy.contains('Toegankelijkheid')
    })

    it('checks if programma is clickable', () => {
        cy.visit ('http://localhost:3000/')
        cy.contains('Menu').click()
        cy.contains('Programma').click()
        cy.url().should('include', '/Programma')
    })

    it('checks if over ons is clickable', () => {
        cy.visit ('http://localhost:3000/')
        cy.contains('Menu').click()
        cy.contains('Over ons').click()
        cy.url().should('include', '/OverOns')
    })

    it('checks if huren is clickable', () => {
        cy.visit ('http://localhost:3000/')
        cy.contains('Menu').click()
        cy.contains('Huur').click()
        cy.url().should('include', '/Huren')
    })

    it('checks if account is clickable', () => {
        cy.visit ('http://localhost:3000/')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.url().should('include', '/Account')
    })

    it('checks if winkelmand is clickable', () => {
        cy.visit ('http://localhost:3000/')
        cy.contains('Menu').click()
        cy.contains('Winkelmand').click()
        cy.url().should('include', '/Winkelmand')
    })

    it('checks if toegankelijkheid is clickable', () => {
        cy.visit ('http://localhost:3000/')
        cy.contains('Menu').click()
        cy.contains('Toegankelijkheid').click()
        cy.url().should('include', '/Accesibility')
    })

    it('checks if the logo is clickable', () => {
        cy.visit ('http://localhost:3000/Programma')
        cy.contains('Laaktheater').click()
        cy.url().should('include', '/')
    })

    it('checks if the bestel button is clickable', () => {
        cy.visit ('http://localhost:3000')
        cy.contains('Bestel').click()
        cy.url().should('include', '/Programma')
    })
})