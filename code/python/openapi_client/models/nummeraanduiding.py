# coding: utf-8

"""
    Huidige bevragingen API

    Deze API levert actuele gegevens over adressen, adresseerbaar objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: bag@kadaster.nl
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class Nummeraanduiding(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'identificatie': 'str',
        'domein': 'str',
        'huisnummer': 'int',
        'huisletter': 'str',
        'huisnummertoevoeging': 'str',
        'postcode': 'str',
        'status': 'StatusNaamgevingEnum',
        'geconstateerd': 'bool',
        'documentdatum': 'date',
        'documentnummer': 'str',
        'woonplaats_identificatie': 'str',
        'openbare_ruimte_identificatie': 'str',
        'mogelijk_onjuist': 'NummeraanduidingMogelijkOnjuist'
    }

    attribute_map = {
        'identificatie': 'identificatie',
        'domein': 'domein',
        'huisnummer': 'huisnummer',
        'huisletter': 'huisletter',
        'huisnummertoevoeging': 'huisnummertoevoeging',
        'postcode': 'postcode',
        'status': 'status',
        'geconstateerd': 'geconstateerd',
        'documentdatum': 'documentdatum',
        'documentnummer': 'documentnummer',
        'woonplaats_identificatie': 'woonplaatsIdentificatie',
        'openbare_ruimte_identificatie': 'openbareRuimteIdentificatie',
        'mogelijk_onjuist': 'mogelijkOnjuist'
    }

    def __init__(self, identificatie=None, domein=None, huisnummer=None, huisletter=None, huisnummertoevoeging=None, postcode=None, status=None, geconstateerd=None, documentdatum=None, documentnummer=None, woonplaats_identificatie=None, openbare_ruimte_identificatie=None, mogelijk_onjuist=None, local_vars_configuration=None):  # noqa: E501
        """Nummeraanduiding - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._identificatie = None
        self._domein = None
        self._huisnummer = None
        self._huisletter = None
        self._huisnummertoevoeging = None
        self._postcode = None
        self._status = None
        self._geconstateerd = None
        self._documentdatum = None
        self._documentnummer = None
        self._woonplaats_identificatie = None
        self._openbare_ruimte_identificatie = None
        self._mogelijk_onjuist = None
        self.discriminator = None

        if identificatie is not None:
            self.identificatie = identificatie
        if domein is not None:
            self.domein = domein
        if huisnummer is not None:
            self.huisnummer = huisnummer
        if huisletter is not None:
            self.huisletter = huisletter
        if huisnummertoevoeging is not None:
            self.huisnummertoevoeging = huisnummertoevoeging
        if postcode is not None:
            self.postcode = postcode
        if status is not None:
            self.status = status
        if geconstateerd is not None:
            self.geconstateerd = geconstateerd
        if documentdatum is not None:
            self.documentdatum = documentdatum
        if documentnummer is not None:
            self.documentnummer = documentnummer
        if woonplaats_identificatie is not None:
            self.woonplaats_identificatie = woonplaats_identificatie
        if openbare_ruimte_identificatie is not None:
            self.openbare_ruimte_identificatie = openbare_ruimte_identificatie
        if mogelijk_onjuist is not None:
            self.mogelijk_onjuist = mogelijk_onjuist

    @property
    def identificatie(self):
        """Gets the identificatie of this Nummeraanduiding.  # noqa: E501


        :return: The identificatie of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._identificatie

    @identificatie.setter
    def identificatie(self, identificatie):
        """Sets the identificatie of this Nummeraanduiding.


        :param identificatie: The identificatie of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._identificatie = identificatie

    @property
    def domein(self):
        """Gets the domein of this Nummeraanduiding.  # noqa: E501

        Het domein waartoe de identificatie behoort.  # noqa: E501

        :return: The domein of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._domein

    @domein.setter
    def domein(self, domein):
        """Sets the domein of this Nummeraanduiding.

        Het domein waartoe de identificatie behoort.  # noqa: E501

        :param domein: The domein of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._domein = domein

    @property
    def huisnummer(self):
        """Gets the huisnummer of this Nummeraanduiding.  # noqa: E501

        Nummer dat door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :return: The huisnummer of this Nummeraanduiding.  # noqa: E501
        :rtype: int
        """
        return self._huisnummer

    @huisnummer.setter
    def huisnummer(self, huisnummer):
        """Sets the huisnummer of this Nummeraanduiding.

        Nummer dat door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :param huisnummer: The huisnummer of this Nummeraanduiding.  # noqa: E501
        :type: int
        """

        self._huisnummer = huisnummer

    @property
    def huisletter(self):
        """Gets the huisletter of this Nummeraanduiding.  # noqa: E501

        Toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :return: The huisletter of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._huisletter

    @huisletter.setter
    def huisletter(self, huisletter):
        """Sets the huisletter of this Nummeraanduiding.

        Toevoeging aan een huisnummer in de vorm van een letter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :param huisletter: The huisletter of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._huisletter = huisletter

    @property
    def huisnummertoevoeging(self):
        """Gets the huisnummertoevoeging of this Nummeraanduiding.  # noqa: E501

        Toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :return: The huisnummertoevoeging of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._huisnummertoevoeging

    @huisnummertoevoeging.setter
    def huisnummertoevoeging(self, huisnummertoevoeging):
        """Sets the huisnummertoevoeging of this Nummeraanduiding.

        Toevoeging aan een huisnummer of een combinatie van huisnummer en huisletter die door de gemeente aan een adresseerbaar object is gegeven.  # noqa: E501

        :param huisnummertoevoeging: The huisnummertoevoeging of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._huisnummertoevoeging = huisnummertoevoeging

    @property
    def postcode(self):
        """Gets the postcode of this Nummeraanduiding.  # noqa: E501

        Door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.  # noqa: E501

        :return: The postcode of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._postcode

    @postcode.setter
    def postcode(self, postcode):
        """Sets the postcode of this Nummeraanduiding.

        Door PostNL vastgestelde code die bij een bepaalde combinatie van een straatnaam en een huisnummer hoort.  # noqa: E501

        :param postcode: The postcode of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._postcode = postcode

    @property
    def status(self):
        """Gets the status of this Nummeraanduiding.  # noqa: E501


        :return: The status of this Nummeraanduiding.  # noqa: E501
        :rtype: StatusNaamgevingEnum
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this Nummeraanduiding.


        :param status: The status of this Nummeraanduiding.  # noqa: E501
        :type: StatusNaamgevingEnum
        """

        self._status = status

    @property
    def geconstateerd(self):
        """Gets the geconstateerd of this Nummeraanduiding.  # noqa: E501

        Indicator dat de nummeraanduiding in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. De nummeraanduiding is mogelijk illegaal.  # noqa: E501

        :return: The geconstateerd of this Nummeraanduiding.  # noqa: E501
        :rtype: bool
        """
        return self._geconstateerd

    @geconstateerd.setter
    def geconstateerd(self, geconstateerd):
        """Sets the geconstateerd of this Nummeraanduiding.

        Indicator dat de nummeraanduiding in de registratie is opgenomen door een feitelijke constatering, zonder dat er sprake was van een brondocument/vergunning. De nummeraanduiding is mogelijk illegaal.  # noqa: E501

        :param geconstateerd: The geconstateerd of this Nummeraanduiding.  # noqa: E501
        :type: bool
        """

        self._geconstateerd = geconstateerd

    @property
    def documentdatum(self):
        """Gets the documentdatum of this Nummeraanduiding.  # noqa: E501

        De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.  # noqa: E501

        :return: The documentdatum of this Nummeraanduiding.  # noqa: E501
        :rtype: date
        """
        return self._documentdatum

    @documentdatum.setter
    def documentdatum(self, documentdatum):
        """Sets the documentdatum of this Nummeraanduiding.

        De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.  # noqa: E501

        :param documentdatum: The documentdatum of this Nummeraanduiding.  # noqa: E501
        :type: date
        """

        self._documentdatum = documentdatum

    @property
    def documentnummer(self):
        """Gets the documentnummer of this Nummeraanduiding.  # noqa: E501

        Identificatie van het brondocument dat ten grondslag ligt aan de opname, mutatie of een verwijdering van gegevens.  # noqa: E501

        :return: The documentnummer of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._documentnummer

    @documentnummer.setter
    def documentnummer(self, documentnummer):
        """Sets the documentnummer of this Nummeraanduiding.

        Identificatie van het brondocument dat ten grondslag ligt aan de opname, mutatie of een verwijdering van gegevens.  # noqa: E501

        :param documentnummer: The documentnummer of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._documentnummer = documentnummer

    @property
    def woonplaats_identificatie(self):
        """Gets the woonplaats_identificatie of this Nummeraanduiding.  # noqa: E501

        Een nummeraanduiding ligt in een woonplaats.  # noqa: E501

        :return: The woonplaats_identificatie of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._woonplaats_identificatie

    @woonplaats_identificatie.setter
    def woonplaats_identificatie(self, woonplaats_identificatie):
        """Sets the woonplaats_identificatie of this Nummeraanduiding.

        Een nummeraanduiding ligt in een woonplaats.  # noqa: E501

        :param woonplaats_identificatie: The woonplaats_identificatie of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._woonplaats_identificatie = woonplaats_identificatie

    @property
    def openbare_ruimte_identificatie(self):
        """Gets the openbare_ruimte_identificatie of this Nummeraanduiding.  # noqa: E501

        Een nummeraanduiding ligt aan een openbare ruimte.  # noqa: E501

        :return: The openbare_ruimte_identificatie of this Nummeraanduiding.  # noqa: E501
        :rtype: str
        """
        return self._openbare_ruimte_identificatie

    @openbare_ruimte_identificatie.setter
    def openbare_ruimte_identificatie(self, openbare_ruimte_identificatie):
        """Sets the openbare_ruimte_identificatie of this Nummeraanduiding.

        Een nummeraanduiding ligt aan een openbare ruimte.  # noqa: E501

        :param openbare_ruimte_identificatie: The openbare_ruimte_identificatie of this Nummeraanduiding.  # noqa: E501
        :type: str
        """

        self._openbare_ruimte_identificatie = openbare_ruimte_identificatie

    @property
    def mogelijk_onjuist(self):
        """Gets the mogelijk_onjuist of this Nummeraanduiding.  # noqa: E501


        :return: The mogelijk_onjuist of this Nummeraanduiding.  # noqa: E501
        :rtype: NummeraanduidingMogelijkOnjuist
        """
        return self._mogelijk_onjuist

    @mogelijk_onjuist.setter
    def mogelijk_onjuist(self, mogelijk_onjuist):
        """Sets the mogelijk_onjuist of this Nummeraanduiding.


        :param mogelijk_onjuist: The mogelijk_onjuist of this Nummeraanduiding.  # noqa: E501
        :type: NummeraanduidingMogelijkOnjuist
        """

        self._mogelijk_onjuist = mogelijk_onjuist

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Nummeraanduiding):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, Nummeraanduiding):
            return True

        return self.to_dict() != other.to_dict()
