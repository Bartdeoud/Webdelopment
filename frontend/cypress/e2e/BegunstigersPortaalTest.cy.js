describe('Begunstigers portaal test', () => {
    it ('Check if begunstigers portaal is reachable', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net')
        cy.contains('Menu').click()
        cy.contains('Account').click()
        cy.contains('Klik dan hier om naar het begunstigersportaal te gaan.').click()
        cy.url().should('include', '/BegunstigersPortaal')
    })

    it ('Check if begunstigers portaal is displayed correctly (no login)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/BegunstigersPortaal')
        cy.contains('U bent geen begunstigers')
        cy.contains('Begunstiger worden')
    })

    it ('Check if begunstigers portaal is displayed correctly (login)', () => {
        // Setup
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Donateur')
        cy.get('#password').type('DonateurW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')

        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/BegunstigersPortaal')
        cy.contains('Begunstigers portaal')
    })
})